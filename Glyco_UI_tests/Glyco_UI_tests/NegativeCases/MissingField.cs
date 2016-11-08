using Glyco_UI_tests.Models;
using Glyco_UI_tests.Setups;
using Glyco_UI_tests.SubSteps;
using NUnit.Framework;

namespace Glyco_UI_tests.NegativeCases
{
    [TestFixture]
    public class MissingField : TestSetUp
    {
        /// <summary>
        /// Try to register a new user with empty name
        /// Steps:
        /// 1) Create a new user
        /// 2) Fill all fields except Name on registration form
        /// 3) Press Submit button
        /// 4) Validate that Main registration form still active, because Name field is required
        /// </summary>
        [Test]
        public void EmptyNameField()
        {
            RegistrationSteps steps = new RegistrationSteps();
            steps.GoToRegsitrationForm(driver);

            //Create a new user with empty name
            UserModel user = new UserModel();
            user.Name = null;

            //Fill registration form using driver and created user
            steps.FillRegistrationForm(driver, user);

            //Validate that Main registration form still active, because Name field is required
            Assert.IsTrue(driver.FindElementById(ElementsIds.MainRegistrationFormId).Displayed);
            Assert.IsTrue(driver.FindElementById(ElementsIds.MainRegistrationFormId).Enabled);
        }

        /// <summary>
        /// Try to register a new user with empty username
        /// Steps:
        /// 1) Create a new user
        /// 2) Fill all fields except Username on registration form
        /// 3) Press Submit button
        /// 4) Validate that Main registration form still active, because Username field is required
        /// </summary>
        [Test]
        public void EmptyUsernameField()
        {
            RegistrationSteps steps = new RegistrationSteps();
            steps.GoToRegsitrationForm(driver);

            //Create a new user with empty username
            UserModel user = new UserModel();
            user.Username = null;

            //Fill registration form using driver and created user
            steps.FillRegistrationForm(driver, user);

            //Validate that Main registration form still active, because Username field is required
            Assert.IsTrue(driver.FindElementById(ElementsIds.MainRegistrationFormId).Displayed);
            Assert.IsTrue(driver.FindElementById(ElementsIds.MainRegistrationFormId).Enabled);
        }

        /// <summary>
        /// Try to register a new user with empty Email
        /// Steps:
        /// 1) Create a new user
        /// 2) Fill all fields except Email on registration form
        /// 3) Press Submit button
        /// 4) Validate that Main registration form still active, because Email field is required
        /// </summary>
        [Test]
        public void EmptyEmailField()
        {
            RegistrationSteps steps = new RegistrationSteps();
            steps.GoToRegsitrationForm(driver);

            //Create a new user with empty email
            UserModel user = new UserModel();
            user.Email = null;

            //Fill registration form using driver and created user
            steps.FillRegistrationForm(driver, user);

            //Validate that Main registration form still active, because Email field is required
            Assert.IsTrue(driver.FindElementById(ElementsIds.MainRegistrationFormId).Displayed);
            Assert.IsTrue(driver.FindElementById(ElementsIds.MainRegistrationFormId).Enabled);
        }

        /// <summary>
        /// Try to register a new user with empty password
        /// Steps:
        /// 1) Create a new user
        /// 2) Fill all fields except Password on registration form
        /// 3) Press Submit button
        /// 4) Validate that Main registration form still active, because Password field is required
        /// </summary>
        [Test]
        public void EmptyPasswordField()
        {
            RegistrationSteps steps = new RegistrationSteps();
            steps.GoToRegsitrationForm(driver);

            //Create a new user with empty password
            UserModel user = new UserModel();
            user.Password = null;

            //Fill registration form using driver and created user
            steps.FillRegistrationForm(driver, user);

            //Validate that Main registration form still active, because Password field is required
            Assert.IsTrue(driver.FindElementById(ElementsIds.MainRegistrationFormId).Displayed);
            Assert.IsTrue(driver.FindElementById(ElementsIds.MainRegistrationFormId).Enabled);
        }

        /// <summary>
        /// Try to register a new user without confirmation Type 2 Diabetes
        /// Steps:
        /// 1) Create a new user
        /// 2) Fill all fields except Password on registration form
        /// 3) Press Submit button
        /// 4) Validate that Main registration form still active, because Type 2 Diabetes field is required
        /// </summary>
        [Test]
        public void MissingType2DiabetesConfirmation()
        {
            RegistrationSteps steps = new RegistrationSteps();
            steps.GoToRegsitrationForm(driver);

            //Create a new user who don't confirm Type 2 Diabetes
            UserModel user = new UserModel();
            user.Type2Confirmation = false;

            //Fill registration form using driver and created user
            steps.FillRegistrationForm(driver, user);

            //Validate that Main registration form still active, because Type 2 Diabetes field is required
            Assert.IsTrue(driver.FindElementById(ElementsIds.MainRegistrationFormId).Displayed);
            Assert.IsTrue(driver.FindElementById(ElementsIds.MainRegistrationFormId).Enabled);
        }

        /// <summary>
        /// Try to register a new user without confirmation Terms & Conditionals
        /// Steps:
        /// 1) Create a new user
        /// 2) Fill all fields except Password on registration form
        /// 3) Press Submit button
        /// 4) Validate that Main registration form still active, because Terms & Conditionals field is required
        /// </summary>
        [Test]
        public void MissingTermsConditionalsConfirmation()
        {
            RegistrationSteps steps = new RegistrationSteps();
            steps.GoToRegsitrationForm(driver);

            //Create a new user who don't confirm Terms & Conditionals
            UserModel user = new UserModel();
            user.TC_Confirmation = false;

            //Fill registration form using driver and created user
            steps.FillRegistrationForm(driver, user);

            //Validate that Main registration form still active, because Terms & Conditionals confirmation field is required
            Assert.IsTrue(driver.FindElementById(ElementsIds.MainRegistrationFormId).Displayed);
            Assert.IsTrue(driver.FindElementById(ElementsIds.MainRegistrationFormId).Enabled);
        }

        /// <summary>
        /// Try to register a new user with empty Height
        /// Steps:
        /// 1) Create a new user
        /// 2) Fill all fields on registration form
        /// 3) Press Submit button
        /// 4) Select a gender
        /// 5) Press Next button
        /// 6) Fill Weight field, but skip Height field
        /// 7) Validate that height and weight form still active, because Height field is required
        /// </summary>
        [Test]
        public void MissingUsersHeightField()
        {
            RegistrationSteps steps = new RegistrationSteps();
            steps.GoToRegsitrationForm(driver);

            //Create a new user with empty height field
            UserModel user = new UserModel();
            user.Height = null;

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

            //Validate that height and weight form still active, because height field is required
            Assert.IsTrue(driver.FindElementById(ElementsIds.HeightEditTextId).Displayed);
            Assert.IsTrue(driver.FindElementById(ElementsIds.HeightEditTextId).Enabled);
        }

        /// <summary>
        /// Try to register a new user with empty Weight
        /// Steps:
        /// 1) Create a new user
        /// 2) Fill all fields on registration form
        /// 3) Press Submit button
        /// 4) Select a gender
        /// 5) Press Next button
        /// 6) Fill Height field, but skip Weight field
        /// 7) Validate that height and weight form still active, because Weight field is required
        /// </summary>
        [Test]
        public void MissingUsersWeightField()
        {
            RegistrationSteps steps = new RegistrationSteps();
            steps.GoToRegsitrationForm(driver);

            //Create a new user with empty weight field
            UserModel user = new UserModel();
            user.Weight = null;

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

            //Validate that height and weight form still active, because weight field is required
            Assert.IsTrue(driver.FindElementById(ElementsIds.WeightEditTextId).Displayed);
            Assert.IsTrue(driver.FindElementById(ElementsIds.WeightEditTextId).Enabled);
        }
    }
}
