using NUnit.Framework;
using Glyco_UI_tests.Setups;
using Glyco_UI_tests.Models;
using Glyco_UI_tests.SubSteps;

namespace Glyco_UI_tests.PositiveCases
{
    [TestFixture]
    public class RegistrationProcess : TestSetUp
    {
        /// <summary>
        /// Test whole registration process
        /// Steps:
        /// 1) Create a new user
        /// 2) Fill all fields on registration form
        /// 3) Press Submit button
        /// 4) Select a gender
        /// 5) Press Next button
        /// 6) Set correct height and weight
        /// 7) Press Next button
        /// 8) Set date of birth
        /// 9) Press Next button
        /// 10) Choose user's ethnicity
        /// 11) Press Next button
        /// 12) Open user profile from menu and validate that username and Email are correct
        /// </summary>
        [Test]
        public void SuccessfulRegistration()
        {
            //Create a new user
            UserModel user = new UserModel();

            //Create RegistrationSteps object
            RegistrationSteps steps = new RegistrationSteps();
            steps.CompleteRegistrationProcess(driver, user);            

            //Press Allow button on the permission pop-up
            driver.FindElementById(ElementsIds.PermissionAllowButtonId).Click();

            //Find and click profile menu button
            driver.FindElementById(ElementsIds.ViewGroupToolbarId).FindElementByClassName(ElementsIds.ImageButtonClassName).Click();

            //Extract user's name from the menu and compare it with original user's name
            Assert.AreEqual(user.Name, driver.FindElementById(ElementsIds.UsernameTextViewId).Text);
             
            //Extract user's email from the menu and compare it with original user's email
            Assert.AreEqual(user.Email, driver.FindElementById(ElementsIds.UserEmailTextViewId).Text);
        }

        /// <summary>
        /// Test whole registration process with relogin using user's email as username
        /// Steps:
        /// 1) Create a new user
        /// 2) Fill all fields on registration form
        /// 3) Press Submit button
        /// 4) Select a gender
        /// 5) Press Next button
        /// 6) Set correct height and weight
        /// 7) Press Next button
        /// 8) Set date of birth
        /// 9) Press Next button
        /// 10) Choose user's ethnicity
        /// 11) Press Next button
        /// 12) Open user profile from menu and logout current user
        /// 13) Input user's email as username
        /// 14) Input user's password
        /// 15) Click sign in button
        /// 16) Open user profile from menu and validate that username and Email are correct
        /// </summary>
        [Test]
        public void RegistrationAndReloginUsingEmail()
        {
            //Create a new user
            UserModel user = new UserModel();

            //Create RegistrationSteps object
            RegistrationSteps steps = new RegistrationSteps();
            steps.CompleteRegistrationProcess(driver, user);

            //Press Allow button on the permission pop-up
            driver.FindElementById(ElementsIds.PermissionAllowButtonId).Click();

            //Find and click profile menu button
            driver.FindElementById(ElementsIds.ViewGroupToolbarId).FindElementByClassName(ElementsIds.ImageButtonClassName).Click();

            //Logout current user
            steps.LogoutProcess(driver);

            //Fill user's email field
            driver.FindElementById(ElementsIds.EmailEditTextId).SendKeys(user.Email);

            //Fill user's password field
            driver.FindElementById(ElementsIds.PasswordEditTextId).SendKeys(user.Password);

            //Press Sign In button
            driver.FindElementById(ElementsIds.SignInButtonId).Click();

            //Find and click profile menu button
            driver.FindElementById(ElementsIds.ViewGroupToolbarId).FindElementByClassName(ElementsIds.ImageButtonClassName).Click();

            //Extract user's name from the menu and compare it with original user's name
            Assert.AreEqual(user.Name, driver.FindElementById(ElementsIds.UsernameTextViewId).Text);

            //Extract user's email from the menu and compare it with original user's email
            Assert.AreEqual(user.Email, driver.FindElementById(ElementsIds.UserEmailTextViewId).Text);
        }

        /// <summary>
        /// Test whole registration process with relogin
        /// Steps:
        /// 1) Create a new user
        /// 2) Fill all fields on registration form
        /// 3) Press Submit button
        /// 4) Select a gender
        /// 5) Press Next button
        /// 6) Set correct height and weight
        /// 7) Press Next button
        /// 8) Set date of birth
        /// 9) Press Next button
        /// 10) Choose user's ethnicity
        /// 11) Press Next button
        /// 12) Open user profile from menu and logout current user
        /// 13) Input user's email as username
        /// 14) Input user's password
        /// 15) Click sign in button
        /// 16) Open user profile from menu and validate that username and Email are correct
        /// </summary>
        [Test]
        public void RegistrationAndReloginUsingUsername()
        {
            //Create a new user
            UserModel user = new UserModel();

            //Create RegistrationSteps object
            RegistrationSteps steps = new RegistrationSteps();
            steps.CompleteRegistrationProcess(driver, user);

            //Press Allow button on the permission pop-up
            driver.FindElementById(ElementsIds.PermissionAllowButtonId).Click();

            //Find and click profile menu button
            driver.FindElementById(ElementsIds.ViewGroupToolbarId).FindElementByClassName(ElementsIds.ImageButtonClassName).Click();

            //Logout current user
            steps.LogoutProcess(driver);

            //Relogin
            //Input user's email in the username field
            driver.FindElementById(ElementsIds.EmailEditTextId).SendKeys(user.Username);

            //Input user's password in the password field
            driver.FindElementById(ElementsIds.PasswordEditTextId).SendKeys(user.Password);

            //Press Sign In button
            driver.FindElementById(ElementsIds.SignInButtonId).Click();

            //Find and click profile menu button
            driver.FindElementById(ElementsIds.ViewGroupToolbarId).FindElementByClassName(ElementsIds.ImageButtonClassName).Click();

            //Extract user's name from the menu and compare it with original user's name
            Assert.AreEqual(user.Name, driver.FindElementById(ElementsIds.UsernameTextViewId).Text);

            //Extract user's email from the menu and compare it with original user's email
            Assert.AreEqual(user.Email, driver.FindElementById(ElementsIds.UserEmailTextViewId).Text);
        }
    }
}
