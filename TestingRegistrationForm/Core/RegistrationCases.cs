using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Threading;
using OpenQA.Selenium.Support.PageObjects;
using TestingRegistrationForm.Core;
using OpenQA.Selenium.Interactions;
using TestingRegistrationForm.Pages;
using System.IO;
using TestingRegistrationForm.Tests;
using OpenQA.Selenium.Support.Extensions;
using System.Collections.ObjectModel;
using TestingRegistrationForm.Core.entity;

namespace TestingRegistrationForm.Core
{
    public class RegistrationCases : BasePage
    {

        By ErrorEmptyEmailMessageLocator = By.XPath("//span[@for='UsernameOrEmail']"); 
        By ErrorEmptyFirstNameMessageLocator = By.XPath("//span[@for='FirstName']");
        By ErrorEmptyLastNameMessageLocator = By.XPath("//span[@for='LastName']");
        By ErrorEmptyPasswordmessageLocator = By.XPath("//span[@for='ConfirmUserPassword']");
        By ErrorConfirmPasswordLocator = By.XPath("//span[contains(text(),'The password and confirmation password do not matc')]");
        By ErrorEmptyPhoneMessageLocator = By.XPath("//span[@for='Phone']");
        By ErrorEmptyOrgNameMessageLocator = By.XPath("//span[@for='ConfirmUserPassword']");
        By WelcomePageLocator = By.XPath("//h1[contains(text(),'WELCOME')]");
        By PasswordStrengthLocator = By.XPath("//span[contains(text(),'Password strength')]");
        By SignWithGoogleButtonLocator = By.XPath("//span[contains(text(),'Sign up with G Suite Directory')]");
        By SignWithAzureButtonLocator = By.XPath("//span[contains(text(),'Sign up with Azure Directory')]");

        public void Registration(Fields fields)
        {
            new RegistrationPage()
            .SetEmail(fields.GetEmail())
            //First/Last name fields with upper and lower case 
            .SetFirstName(fields.GetFirstName())
            .SetLastName(fields.GetLastName())
            .SetPassword(fields.GetPassword())
            .SetConfirmPassword(fields.GetConfirmPassword())
            .SetPhone(fields.GetPhone())
            //Organization name with upper and lower case 
            .SetOrgName(fields.GetOrgName())
            .Submit();
           
        }

        public void RegistrationAndCheckEmail(Fields fields)
        {
            new RegistrationPage()
            .SetEmail(fields.GetEmail())
            //First/Last name fields with upper and lower case 
            .SetFirstName(fields.GetFirstName())
            .SetLastName(fields.GetLastName())
            .SetPassword(fields.GetPassword())
            .SetConfirmPassword(fields.GetConfirmPassword())
            .SetPhone(fields.GetPhone())
            //Organization name with upper and lower case 
            .SetOrgName(fields.GetOrgName())
            .Submit();
             new WelcomePage()
             .ClickInbox();

        }
        public string GetWelcomePageMessage()
        {
            Element.WaitUntilDisplayed(WelcomePageLocator, 3000);
            return Element.FindElement(WelcomePageLocator).Text;
        }
        public string GetErrorEmtyEmailMessage()
        {
            Element.WaitUntilDisplayed(ErrorEmptyEmailMessageLocator, 3000);
            return Element.FindElement(ErrorEmptyEmailMessageLocator).Text;
        }
        public string GetErrorEmtyFirstNameMessage()
        {
            Element.WaitUntilDisplayed(ErrorEmptyFirstNameMessageLocator, 3000);
            return Element.FindElement(ErrorEmptyFirstNameMessageLocator).Text;
        }
        public string GetErrorEmtyLastNameMessage()
        {
            Element.WaitUntilDisplayed(ErrorEmptyLastNameMessageLocator, 3000);
            return Element.FindElement(ErrorEmptyLastNameMessageLocator).Text;
        }
        public string GetErrorEmtyPasswordMessage()
        {
            Element.WaitUntilDisplayed(ErrorEmptyPasswordmessageLocator, 3000);
            return Element.FindElement(ErrorEmptyPasswordmessageLocator).Text;
        }
        public string GetErrorEmtyPhoneMessage()
        {
            Element.WaitUntilDisplayed(ErrorEmptyPhoneMessageLocator, 3000);
            return Element.FindElement(ErrorEmptyPhoneMessageLocator).Text;
        }
        public string GetErrorConfirmPasswordMessage()
        {
            Element.WaitUntilDisplayed(ErrorConfirmPasswordLocator, 3000);
            return Element.FindElement(ErrorConfirmPasswordLocator).Text;
        }
        public string GetErrorEmtyOrgNameMessage()
        {
            Element.WaitUntilDisplayed(ErrorEmptyOrgNameMessageLocator, 3000);
            return Element.FindElement(ErrorEmptyOrgNameMessageLocator).Text;
        }
        public string GetPasswordStrengthMessage()
        {
            Element.WaitUntilDisplayed(PasswordStrengthLocator, 3000);
            return Element.FindElement(PasswordStrengthLocator).Text;
        }


    }
}
