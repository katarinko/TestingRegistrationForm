using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingRegistrationForm.Core;

namespace TestingRegistrationForm.Pages
{
    public class RegistrationPage : BasePage
    {
        By RegistrationPageLocator = By.XPath("//h2[contains(text(),'REGISTRATION')]");
        By EmailLocator = By.Name("UsernameOrEmail");
        By FirstNameLocator = By.Name("FirstName");
        By LastNameLocator = By.Name("LastName");
        By PasswordLocator = By.Name("UserPassword");
        By ConfirmPasswordLocator = By.XPath("//div[5]//input[1]");
        By PhoneLocator = By.Name("Phone");
        By OrganizationNameLocator = By.Name("OrgDisplayName");

        By SubmitButtonLocator = By.XPath("//input[@id='signupbtn']");
        By ErrorMessageLocator = By.XPath("//span[@class='field - validation - error']");
        By ErrorConfirmPasswordLocator = By.XPath("//span[contains(text(),'The password and confirmation password do not matc')]");
        By SignWithGoogleButtonLocator = By.XPath("//span[contains(text(),'Sign up with G Suite Directory')]");
        By SignWithAzureButtonLocator = By.XPath("//span[contains(text(),'Sign up with Azure Directory')]");
       // By InboxButtonLocator = By.XPath("//label[@class='title']");

        public RegistrationPage()
        {
            WaitPageLoaded(RegistrationPageLocator, 6000, "Registration Page");
        }

        public RegistrationPage SetEmail(String email)
        {
            Element.WaitUntilDisplayed(EmailLocator, 5000);
            //Element.ClearField(EmailLocator);
            Element.InputText(EmailLocator, email);
            return this;
        }
        public RegistrationPage SetLastName(String lastName)
        {
            Element.WaitUntilDisplayed(LastNameLocator, 5000);
            Element.InputText(LastNameLocator, lastName);
            return this;
        }
        public RegistrationPage SetFirstName(String firstName)
        {
            Element.WaitUntilDisplayed(FirstNameLocator, 5000);
            Element.InputText(FirstNameLocator, firstName);
            return this;
        }
        public RegistrationPage SetPassword(String password)
        {
            Element.WaitUntilDisplayed(PasswordLocator, 5000);
            Element.InputText(PasswordLocator, password);
            return this;
        }
        public RegistrationPage SetConfirmPassword(String confirmPassword)
        {
            Element.WaitUntilDisplayed(ConfirmPasswordLocator, 5000);
            Element.InputText(ConfirmPasswordLocator, confirmPassword);
            return this;
        }
        public RegistrationPage SetPhone(String phone)
        {
            Element.WaitUntilDisplayed(PhoneLocator, 5000);
            Element.InputText(PhoneLocator, phone);
            return this;
        }
        public RegistrationPage SetOrgName(String organizationName)
        {
            Element.WaitUntilDisplayed(OrganizationNameLocator, 5000);
            Element.InputText(OrganizationNameLocator, organizationName);
            return this;
        }
        public void Submit()
        {
            Element.WaitUntilDisplayed(SubmitButtonLocator, 3000);
            Element.Click(SubmitButtonLocator);
        }

       
        public string GetErrorConfirmPasswordMessage()
        {
            return Element.FindElement(ErrorConfirmPasswordLocator).Text;
        }

        public string GetErrorMessage()
        {
            return Element.FindElement(ErrorMessageLocator).Text;
        }
       
        public void ClickSignInGoogleAcount()
        {
            Element.WaitUntilDisplayed(SignWithGoogleButtonLocator, 3000);
            Element.Click(SignWithGoogleButtonLocator);
        }
        public void ClickSignInAzureAcount()
        {
            Element.WaitUntilDisplayed(SignWithAzureButtonLocator, 3000);
            Element.Click(SignWithAzureButtonLocator);
        }

    }
}