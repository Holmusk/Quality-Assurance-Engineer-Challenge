using Glyco_UI_tests.Models;
using Glyco_UI_tests.Setups;
using Glyco_UI_tests.SubSteps;
using NUnit.Framework;

namespace Glyco_UI_tests.PositiveCases
{
    [TestFixture]
    public class Navigation : TestSetUp
    {
        /// <summary>
        /// Check that Previous button works correct during registration
        /// /// Steps:
        /// 1) Create a new user
        /// 2) Fill all fields on registration form. 
        /// 3) Press Submit button
        /// 4) Press Previous button
        /// 5) Validate that user's data display on registration form
        /// </summary>
        [Test]
        public void RegisterFormValidation()
        {
            RegistrationSteps steps = new RegistrationSteps();
            steps.GoToRegsitrationForm(driver);

            //Create a new user
            UserModel user = new UserModel();

            //Fill registration form using driver and created user
            steps.FillRegistrationForm(driver, user);

            //Press Previous button
            driver.FindElementById(ElementsIds.PreviousButtonId).Click();

            //Validate that user's data display on Register form

            Assert.AreEqual(user.Name, driver.FindElementById(ElementsIds.NameEditTextId).Text);
            Assert.AreEqual(user.Username, driver.FindElementById(ElementsIds.UsernameEditTextId).Text);
            Assert.AreEqual(user.Email, driver.FindElementById(ElementsIds.EmailEditTextId).Text);
            Assert.AreEqual(user.Password, driver.FindElementById(ElementsIds.PasswordEditTextId).Text);
            Assert.True(driver.FindElementById(ElementsIds.ConfirmType2CheckBoxId).Selected);
            Assert.True(driver.FindElementById(ElementsIds.ConfirmTCCheckBoxId).Selected);
        }

        /// <summary>
        /// Try to register a new user with very small height
        /// Steps:
        /// 1) Create a new user
        /// 2) Fill all fields on registration form
        /// 3) Press Submit button
        /// 4) Select a gender
        /// 5) Press Next button
        /// 6) Set correct height and weight
        /// 7) Press Previous button
        /// 8) Validate that user's data display on registration form
        /// </summary>
        [Test]
        public void HeightAndWeightFormValidation()
        {
            RegistrationSteps steps = new RegistrationSteps();
            steps.GoToRegsitrationForm(driver);

            //Create a new user
            UserModel user = new UserModel();

            //Fill registration form using driver and created user
            steps.FillRegistrationForm(driver, user);

            //Choose current gender
            steps.ChooseUserGender(driver, user);

            //Press Next button
            driver.FindElementById(ElementsIds.NextButtonId).Click();

            //Fill height and weight form using driver and created user
            steps.FillHeightWeightForm(driver, user);

            //Press Next button
            driver.FindElementById(ElementsIds.NextButtonId).Click();

            //Press Previous button
            driver.FindElementById(ElementsIds.PreviousButtonId).Click();

            //Validate that user's data display on height and weight form

            Assert.AreEqual(user.Height.ToString(), driver.FindElementById(ElementsIds.HeightEditTextId).Text);
            Assert.AreEqual(user.Weight.ToString(), driver.FindElementById(ElementsIds.WeightEditTextId).Text);
        }
    }
}
