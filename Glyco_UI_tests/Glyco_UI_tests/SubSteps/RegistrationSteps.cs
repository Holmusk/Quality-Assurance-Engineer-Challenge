using Glyco_UI_tests.Models;
using Glyco_UI_tests.Setups;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System.Linq;

namespace Glyco_UI_tests.SubSteps
{
    /// <summary>
    /// This class contains steps of registration process
    /// </summary>
    public class RegistrationSteps
    {
        public void GoToRegsitrationForm(AndroidDriver<AppiumWebElement> driver)
        {
            //Find and press Register button
            driver.FindElementById(ElementsIds.RegisterButtonId).Click();

            //Find and press Continue button
            driver.FindElementById(ElementsIds.ContinueButtonId).Click();
        }

        /// <summary>
        /// Steps for filling and submitting registration form
        /// </summary>
        public void FillRegistrationForm(AndroidDriver<AppiumWebElement> driver, UserModel user)
        {
            //Fill user's name field
            if (user.Name != null)
                driver.FindElementById(ElementsIds.NameEditTextId).SendKeys(user.Name);

            //Fill user's username field
            if (user.Username != null)
                driver.FindElementById(ElementsIds.UsernameEditTextId).SendKeys(user.Username);

            //Fill user's email field
            if (user.Email != null)
                driver.FindElementById(ElementsIds.EmailEditTextId).SendKeys(user.Email);

            //Fill user's password field
            if (user.Password != null)
                driver.FindElementById(ElementsIds.PasswordEditTextId).SendKeys(user.Password);

            //Hide keyboard
            driver.HideKeyboard();

            //Confirm type 2 diabetes
            if(user.Type2Confirmation)
                driver.FindElementById(ElementsIds.ConfirmType2CheckBoxId).Click();

            //Confirm terms and conditions
            if(user.TC_Confirmation)
                driver.FindElementById(ElementsIds.ConfirmTCCheckBoxId).Click();

            //Press Submit button
            driver.FindElementById(ElementsIds.SubmitButtonId).Click();
        }

        public void ChooseUserGender(AndroidDriver<AppiumWebElement> driver, UserModel user)
        {
            //Choose current gender
            var genderElement = user.Gender ? driver.FindElementById(ElementsIds.GenderMaleImageViewId) : driver.FindElementById(ElementsIds.GenderFemaleImageViewId);
            genderElement.Click();
        }

        /// <summary>
        /// Steps for filling user's height and weight
        /// </summary>
        public void FillHeightWeightForm(AndroidDriver<AppiumWebElement> driver, UserModel user)
        {
            //Fill user's height field
            if(user.Height != null)
                driver.FindElementById(ElementsIds.HeightEditTextId).SendKeys(user.Height.ToString());

            //Fill user's weight field
            if (user.Weight != null)
                driver.FindElementById(ElementsIds.WeightEditTextId).SendKeys(user.Weight.ToString());

            //Hide keyboard
            driver.HideKeyboard();
        }

        /// <summary>
        /// Steps for setting year of birth for user
        /// </summary>
        public void SetYearOfBirth(AndroidDriver<AppiumWebElement> driver, UserModel user)
        {
            //Click on Year
            driver.FindElementById(ElementsIds.YearDatePickerId).Click();

            //Select user's year of birth
            var elements = driver.FindElementsById(ElementsIds.ElementOfListOfYearsId);
            elements.FirstOrDefault(element => element.Text == user.DateOfBirth.Year.ToString()).Click();
        }

        /// <summary>
        /// Steps for choosing ethnicity for user
        /// </summary>
        public void ChooseEthnicity(AndroidDriver<AppiumWebElement> driver, UserModel user)
        {
            //Click on ethnicity spinner
            driver.FindElementById(ElementsIds.EthnicitySpinnerId).Click();

            //Select user's ethnicity
            var elements = driver.FindElementsById(ElementsIds.EthnicitySpinnerTargetId);
            elements.FirstOrDefault(element => element.Text == user.Ethnicity).Click();
        }

        /// <summary>
        /// Steps for logout
        /// </summary>
        public void LogoutProcess(AndroidDriver<AppiumWebElement> driver)
        {
            var elements = driver.FindElementsById(ElementsIds.DesignMenuItemTextId);

            int startx = elements.FirstOrDefault(element => element.Text == "Blood Glucose Units").Location.X;
            int starty = elements.FirstOrDefault(element => element.Text == "Blood Glucose Units").Location.Y;
            int endx = elements.FirstOrDefault(element => element.Text == "App Settings").Location.X;
            int endy = elements.FirstOrDefault(element => element.Text == "App Settings").Location.Y;

            driver.Swipe(endx, endy, startx, starty, 500);

            elements = driver.FindElementsById(ElementsIds.DesignMenuItemTextId);
            elements.FirstOrDefault(element => element.Text == "Log out").Click();
        }

        /// <summary>
        /// Whole registration process
        /// </summary>
        public void CompleteRegistrationProcess(AndroidDriver<AppiumWebElement> driver, UserModel user)
        {
            GoToRegsitrationForm(driver);

            //Fill registration form using driver and created user
            FillRegistrationForm(driver, user);

            //Choose current gender
            ChooseUserGender(driver, user);

            //Press Next button
            driver.FindElementById(ElementsIds.NextButtonId).Click();

            //Fill height and weight form using driver and created user
            FillHeightWeightForm(driver, user);

            //Press Next button
            driver.FindElementById(ElementsIds.NextButtonId).Click();

            //Set year of birth
            SetYearOfBirth(driver, user);

            //Press Next button
            driver.FindElementById(ElementsIds.NextButtonId).Click();

            //Click on ethnicity spinner
            ChooseEthnicity(driver, user);

            //Press Next button
            driver.FindElementById(ElementsIds.NextButtonId).Click();
        }
    }
}
