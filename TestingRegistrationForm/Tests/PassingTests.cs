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
using TestingRegistrationForm.Tests.Data;
//using TestingRegistrationForm.Tests.Data.RegistrationDataTest;
using OpenQA.Selenium.Support.Extensions;
using System.Collections.ObjectModel;
using TestingRegistrationForm.Core.entity;

namespace TestingRegistrationForm.Tests
{
    [TestFixture]
    class PassingTests : BaseTest
     {

        private RegistrationData withStandardData = RegistrationData.GetStandardData();
        private RegistrationData withoutEmail = RegistrationData.GetStandardDataWithoutEmail();
        private RegistrationData withoutFirstName = RegistrationData.GetStandardDataWithoutFirstName ();
        private RegistrationData withoutLastName = RegistrationData.GetStandardDataWithoutLastName();
        private RegistrationData withoutPassword = RegistrationData.GetStandardDataWithoutPassword();
        private RegistrationData withoutConfirmPassword = RegistrationData.GetStandardDataWithoutConfirmPassword();
        private RegistrationData withoutPhone = RegistrationData.GetStandardDataWithoutPhone();
        private RegistrationData withoutOrgName = RegistrationData.GetStandardDataWithoutOrgName();
        private RegistrationData withWeakPassword = RegistrationData.GetWeakPassword();
        private RegistrationData withNormalPassword = RegistrationData.GetNormalPassword();
        private RegistrationData withStrongPassword = RegistrationData.GetStrongPassword();
        private RegistrationData withPhoneWrongFormat = RegistrationData.GetPhoneWithWrongFormat();
        private RegistrationData withPhoneLessNumber = RegistrationData.GetPhoneWithLessNumbers();
        private RegistrationData withSpaces = RegistrationData.GetRegistrationWithSpaces();

        [Test Order(1)]

        public void RegistrationWithStandardInfo()
        {
            var registrationCases = new RegistrationCases();
            registrationCases.Registration(withStandardData);
            StringAssert.Contains(Alerts.welcomePageMessage, registrationCases.GetWelcomePageMessage(), "Please could you fill all requirements fields");
        }

        [Test Order(2)]
        public void RegistrationWithoutEmail()
        {

            var registrationCases = new RegistrationCases();
            registrationCases.Registration(withoutEmail);
            StringAssert.Contains(Alerts.errorEmptyMessage, registrationCases.GetErrorEmtyEmailMessage() , Alerts.assertEmptyMessage);
        }
       
        [Test Order(3)]

        public void RegistrationWithoutFirstName()
        {
           var registrationCases = new RegistrationCases();
           registrationCases.Registration(withoutFirstName);
           StringAssert.Contains(Alerts.errorEmptyMessage, registrationCases.GetErrorEmtyFirstNameMessage(), Alerts.assertEmptyMessage);
          
    }
    [Test Order(4)]
        public void RegistrationWithoutLastName()
        {
            var registrationCases = new RegistrationCases();
            registrationCases.Registration(withoutLastName);
            StringAssert.Contains(Alerts.errorEmptyMessage, registrationCases.GetErrorEmtyLastNameMessage(), Alerts.assertEmptyMessage);
    }

    [Test Order(5)]

        public void RegistrationWithoutPassword()
        {
            var registrationCases = new RegistrationCases();
            registrationCases.Registration(withoutPassword);
            StringAssert.Contains(Alerts.errorEmptyMessage, registrationCases.GetErrorEmtyPasswordMessage(), Alerts.assertEmptyMessage);
    }

    [Test Order(6)]

        public void RegistrationWithoutConfirmPassword()
        {
            var registrationCases = new RegistrationCases();
            registrationCases.Registration(withoutConfirmPassword);
            StringAssert.Contains(Alerts.errorConfirmPasswordMessage, registrationCases.GetErrorConfirmPasswordMessage(), Alerts.assertErrorConfirmPasswordMessage);
        }
        [Test Order(7)]

        public void RegistrationWithoutPhone()
        {
            var registrationCases = new RegistrationCases();
            registrationCases.Registration(withoutPhone);
            StringAssert.Contains(Alerts.errorEmptyMessage, registrationCases.GetErrorEmtyPhoneMessage(), Alerts.assertEmptyMessage);
        }
        [Test Order(8)]

        public void RegistrationWithoutOrgName()
        {
            var registrationCases = new RegistrationCases();
            registrationCases.Registration(withoutOrgName);
            StringAssert.Contains(Alerts.errorEmptyMessage, registrationCases.GetErrorEmtyOrgNameMessage(), Alerts.assertEmptyMessage);
        }
        [Test Order(9)]
        public void TestWeakPassword()
        {
            var registrationCases = new RegistrationCases();
            registrationCases.Registration(withWeakPassword);
            StringAssert.Contains(Alerts.passwordStrengtWeakMessage, registrationCases.GetPasswordStrengthMessage(), "Password strength: weak message should be");
        }
        [Test Order(10)]
        public void TestNormalPassword()
        {
            var registrationCases = new RegistrationCases();
            registrationCases.Registration(withNormalPassword);
            StringAssert.Contains(Alerts.passwordStrengtNormalMessage, registrationCases.GetPasswordStrengthMessage(), "Password strength: normal message should be");
        }
        [Test Order(11)]
        public void TestStrongPassword()
        {
            var registrationCases = new RegistrationCases();
            registrationCases.Registration(withStrongPassword);
            StringAssert.Contains(Alerts.passwordStrengtStrongMessage, registrationCases.GetPasswordStrengthMessage(), "Password strength: strong message should be");
        }
        [Test Order(12)]
        public void TestPhoneFieldWithWrongFormat()
        {
            var registrationCases = new RegistrationCases();
            registrationCases.Registration(withPhoneWrongFormat);
            StringAssert.Contains(Alerts.errorPhoneFormatMessage, registrationCases.GetErrorEmtyPhoneMessage(), "Phone field should use format: +380639992211");
        }
        [Test Order(13)]
        public void TestPhoneFieldWitLessNumbers()
        {
            var registrationCases = new RegistrationCases();
            registrationCases.Registration(withPhoneLessNumber);
            StringAssert.Contains(Alerts.errorPhoneFormatMessage, registrationCases.GetErrorEmtyPhoneMessage(), "Phone field should use format: +380639992211");
        }
        [Test Order(14)]
        public void RegistrationWithSpaces()
        {
            var registrationCases = new RegistrationCases();
            registrationCases.Registration(withSpaces);
            StringAssert.Contains(Alerts.errorEmptyMessage, registrationCases.GetErrorEmtyEmailMessage(), Alerts.assertEmptyMessage);
        }
        [Test Order(15)]
        public void RegistrationWithGoogleAcount()
        {
            var registrationPage = new RegistrationPage();
            registrationPage.ClickSignInGoogleAcount();
            var googleAcountPage = new GoogleAcountPage();
            Assert.IsTrue(googleAcountPage.GoogleAcountIsVisible(), "Function Sign up with G Suite Directory - is unavailable");

        }
        [Test Order(16)]
        public void RegistrationWithAzureAcount()
        {
            var registrationPage = new RegistrationPage();
            registrationPage.ClickSignInAzureAcount();
            var azureAcountPage = new AzureAcountPage();
            Assert.IsTrue(azureAcountPage.AzureAcountIsVisible(), "Function Sign up with Azure Directory - is unavailable");
        }

        [Test Order(17)]
        public void TestingInboxFuntion()
        {
            var registrationCases = new RegistrationCases();
            registrationCases.RegistrationAndCheckEmail(withStandardData);
            var emailPage = new EmailPage();
            Assert.IsTrue(emailPage.EmailPageIsVisible(), "Function Check your inbox! - is unavailable");

        }

    }
}
   

