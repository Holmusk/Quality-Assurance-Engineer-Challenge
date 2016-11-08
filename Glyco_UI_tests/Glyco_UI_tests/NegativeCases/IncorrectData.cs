using Glyco_UI_tests.Models;
using Glyco_UI_tests.Setups;
using Glyco_UI_tests.SubSteps;
using NUnit.Framework;

namespace Glyco_UI_tests.NegativeCases
{
    [TestFixture]
    public class IncorrectData : TestSetUp
    {
        /// <summary>
        /// Try to register a new user with incorret username
        /// Steps:
        /// 1) Create a new user
        /// 2) Fill all fields on registration form. 
        /// 3) In this case username contains several special characters
        /// 4) Press Submit button
        /// 5) Validate that Main registration form still active, because Username field can't contain special characters
        /// </summary>
        [Test]
        public void InputIncorrectUsername()
        {
            RegistrationSteps steps = new RegistrationSteps();
            steps.GoToRegsitrationForm(driver);

            //Create a new user with incorrect username
            UserModel user = new UserModel();
            user.Username += "#@$%";

            //Fill registration form using driver and created user
            steps.FillRegistrationForm(driver, user);

            //Validate that Main registration form still active, because Username field can't contain special characters
            Assert.IsTrue(driver.FindElementById(ElementsIds.MainRegistrationFormId).Displayed);
            Assert.IsTrue(driver.FindElementById(ElementsIds.MainRegistrationFormId).Enabled);
        }

        /// <summary>
        /// Try to register a new user with incorret Email
        /// Steps:
        /// 1) Create a new user
        /// 2) Fill all fields on registration form. 
        /// 3) In this case Email doesn't contains @
        /// 4) Press Submit button
        /// 5) Validate that Main registration form still active, because Email field have to be valid
        /// </summary>
        [Test]
        public void InputIncorrectEmail()
        {
            RegistrationSteps steps = new RegistrationSteps();
            steps.GoToRegsitrationForm(driver);

            //Create a new user with incorrect email
            UserModel user = new UserModel();
            user.Email = "incorrectEmailHere.com";

            //Fill registration form using driver and created user
            steps.FillRegistrationForm(driver, user);

            //Validate that Main registration form still active, because Email field have to be valid
            Assert.IsTrue(driver.FindElementById(ElementsIds.MainRegistrationFormId).Displayed);
            Assert.IsTrue(driver.FindElementById(ElementsIds.MainRegistrationFormId).Enabled);
        }

        /// <summary>
        /// Try to register a new user with incorret Password
        /// Steps:
        /// 1) Create a new user
        /// 2) Fill all fields on registration form. 
        /// 3) In this case Password has lenght only 3 characters
        /// 4) Press Submit button
        /// 5) Validate that Main registration form still active, because Password field have to contain at least 8 characters
        /// </summary>
        [Test]
        public void InputIncorrectPassword()
        {
            RegistrationSteps steps = new RegistrationSteps();
            steps.GoToRegsitrationForm(driver);

            //Create a new user with short password
            UserModel user = new UserModel();
            user.Password = "123";

            //Fill registration form using driver and created user
            steps.FillRegistrationForm(driver, user);

            //Validate that Main registration form still active, because Password field have to contain at least 8 characters
            Assert.IsTrue(driver.FindElementById(ElementsIds.MainRegistrationFormId).Displayed);
            Assert.IsTrue(driver.FindElementById(ElementsIds.MainRegistrationFormId).Enabled);
        }

        /// <summary>
        /// Try to register a new user with very small height
        /// Steps:
        /// 1) Create a new user
        /// 2) Fill all fields on registration form
        /// 3) Press Submit button
        /// 4) Select a gender
        /// 5) Press Next button
        /// 6) Set correct weight, but set height = 4
        /// 7) Validate that height and weight form still active, because height value should be adequate
        /// </summary>
        [Test]
        public void InputVerySmallHeight()
        {
            RegistrationSteps steps = new RegistrationSteps();
            steps.GoToRegsitrationForm(driver);

            //Create a new user with very small height
            UserModel user = new UserModel();
            user.Height = 4;

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

            //Validate that height and weight form still active, because height value should be adequate
            Assert.IsTrue(driver.FindElementById(ElementsIds.HeightEditTextId).Displayed);
            Assert.IsTrue(driver.FindElementById(ElementsIds.HeightEditTextId).Enabled);
        }

        /// <summary>
        /// Try to register a new user with very big height
        /// Steps:
        /// 1) Create a new user
        /// 2) Fill all fields on registration form
        /// 3) Press Submit button
        /// 4) Select a gender
        /// 5) Press Next button
        /// 6) Set correct weight, but set height = 1500
        /// 7) Validate that height and weight form still active, because height value should be adequate
        /// </summary>
        [Test]
        public void InputVeryBigHeight()
        {
            RegistrationSteps steps = new RegistrationSteps();
            steps.GoToRegsitrationForm(driver);

            //Create a new user with very big height
            UserModel user = new UserModel();
            user.Height = 1500;

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

            //Validate that height and weight form still active, because height value should be adequate
            Assert.IsTrue(driver.FindElementById(ElementsIds.HeightEditTextId).Displayed);
            Assert.IsTrue(driver.FindElementById(ElementsIds.HeightEditTextId).Enabled);
        }

        /// <summary>
        /// Try to register a new user with very small weight
        /// Steps:
        /// 1) Create a new user
        /// 2) Fill all fields on registration form
        /// 3) Press Submit button
        /// 4) Select a gender
        /// 5) Press Next button
        /// 6) Set correct height, but set weight = 1
        /// 7) Validate that height and weight form still active, because weight value should be adequate
        /// </summary>
        [Test]
        public void InputVerySmallWeight()
        {
            RegistrationSteps steps = new RegistrationSteps();
            steps.GoToRegsitrationForm(driver);

            //Create a new user with very small weight
            UserModel user = new UserModel();
            user.Weight = 1;

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

            //Validate that height and weight form still active, because weight value should be adequate
            Assert.IsTrue(driver.FindElementById(ElementsIds.WeightEditTextId).Displayed);
            Assert.IsTrue(driver.FindElementById(ElementsIds.WeightEditTextId).Enabled);
        }

        /// <summary>
        /// Try to register a new user with very big weight
        /// Steps:
        /// 1) Create a new user
        /// 2) Fill all fields on registration form
        /// 3) Press Submit button
        /// 4) Select a gender
        /// 5) Press Next button
        /// 6) Set correct height, but set weight = 1500
        /// 7) Validate that height and weight form still active, because weight value should be adequate
        /// </summary>
        [Test]
        public void InputVeryBigWeight()
        {
            RegistrationSteps steps = new RegistrationSteps();
            steps.GoToRegsitrationForm(driver);

            //Create a new user with very big weight
            UserModel user = new UserModel();
            user.Weight = 1500;

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

            //Validate that height and weight form still active, because weight value should be adequate
            Assert.IsTrue(driver.FindElementById(ElementsIds.WeightEditTextId).Displayed);
            Assert.IsTrue(driver.FindElementById(ElementsIds.WeightEditTextId).Enabled);
        }
    }
}
