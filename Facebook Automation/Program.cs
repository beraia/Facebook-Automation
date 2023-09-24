using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook_Automation
{
    internal class Program
    {
        IWebDriver driver = new ChromeDriver();
        static void Main(string[] args)
        {
        }

        [SetUp]
        public void Initialize()
        {
            //Go to Facebook page
            driver.Navigate().GoToUrl("https://www.facebook.com/r.php");
        }

        [Test]
        public void ExecuteTest()
        {
            //Make the browser full screen
            driver.Manage().Window.Maximize();


            // Find registration form elements
            IWebElement firstNameField = driver.FindElement(By.Name("firstname"));
            IWebElement lastNameField = driver.FindElement(By.Name("lastname"));
            IWebElement emailField = driver.FindElement(By.Name("reg_email__"));
            IWebElement confirmEmailField = driver.FindElement(By.Name("reg_email_confirmation__"));
            IWebElement passwordField = driver.FindElement(By.Name("reg_passwd__"));
            IWebElement signUpButton = driver.FindElement(By.Name("websubmit"));
            IWebElement birthdayMonth = driver.FindElement(By.Name("birthday_month"));
            IWebElement day = driver.FindElement(By.Name("birthday_day"));
            IWebElement birthdayYear = driver.FindElement(By.Name("birthday_year"));
            IWebElement gender = driver.FindElement(By.CssSelector("input[value = '2']"));
            IWebElement signUp = driver.FindElement(By.LinkText("Sign Up"));

            // Fill in registration form
            firstNameField.SendKeys("John");
            lastNameField.SendKeys("Doe");
            emailField.SendKeys("youremail@example.com");
            confirmEmailField.SendKeys("youremail@example.com");
            passwordField.SendKeys("yourpassword");

            var selectMonth = new SelectElement(birthdayMonth);
            selectMonth.SelectByValue("10");

            var selectDay = new SelectElement(day);
            selectDay.SelectByValue("7");

            var selectYear = new SelectElement(birthdayYear);
            selectYear.SelectByValue("2002");

            gender.Click();

            // Click the sign-up button
            //signUp.Click();
        }

        [TearDown]
        public void CloseTest()
        {
            //Close the browser
            driver.Quit();
        }

    }
}
