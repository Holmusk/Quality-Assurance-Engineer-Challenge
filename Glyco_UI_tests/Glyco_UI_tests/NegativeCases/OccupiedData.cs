using Glyco_UI_tests.Models;
using Glyco_UI_tests.Setups;
using Glyco_UI_tests.SubSteps;
using NUnit.Framework;

namespace Glyco_UI_tests.NegativeCases
{
    [TestFixture]
    public class OccupiedData : TestSetUp
    {
        /// <summary>
        /// Try to register a new user using occupied username
        /// Steps:
        /// 1) Create a new user
        /// 2) Complete registration process
        /// 3) Logout current user
        /// 4) Create another one user and set their username as previous user
        /// 5) Fill all fields on registration form for a new user
        /// 6) Press submit button
        /// 7) Validate that Main registration form still active, because current username is occupied
        /// </summary>
        [Test]
        public void TryToRegisterWithOccupiedUsername()
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

            //Press Sign up button
            driver.FindElementById(ElementsIds.SignUpTrialButtonId).Click();

            //Go to registration form
            steps.GoToRegsitrationForm(driver);

            //Create another user with occupied username
            UserModel anotherUser = new UserModel();
            anotherUser.Username = user.Username;

            //Fill registration form using driver and created user
            steps.FillRegistrationForm(driver, anotherUser);

            //Validate that Main registration form still active, because current username is occupied
            Assert.IsTrue(driver.FindElementById(ElementsIds.MainRegistrationFormId).Displayed);
            Assert.IsTrue(driver.FindElementById(ElementsIds.MainRegistrationFormId).Enabled);
        }

        /// <summary>
        /// Try to register a new user using occupied Email
        /// Steps:
        /// 1) Create a new user
        /// 2) Complete registration process
        /// 3) Logout current user
        /// 4) Create another one user and set their Email as previous user
        /// 5) Fill all fields on registration form for a new user
        /// 6) Press submit button
        /// 7) Validate that Main registration form still active, because current Email is occupied
        /// </summary>
        [Test]
        public void TryToRegisterWithOccupiedEmail()
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

            //Press Sign up button
            driver.FindElementById(ElementsIds.SignUpTrialButtonId).Click();

            //Go to registration form
            steps.GoToRegsitrationForm(driver);

            //Create another user with occupied username
            UserModel anotherUser = new UserModel();
            anotherUser.Email = user.Email;

            //Fill registration form using driver and created user
            steps.FillRegistrationForm(driver, anotherUser);

            //Validate that Main registration form still active, because current Email is occupied
            Assert.IsTrue(driver.FindElementById(ElementsIds.MainRegistrationFormId).Displayed);
            Assert.IsTrue(driver.FindElementById(ElementsIds.MainRegistrationFormId).Enabled);
        }
    }
}
