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
using TestingRegistrationForm.Core;
using TestingRegistrationForm.Tests;
using TestingRegistrationForm.Tests.Data;


namespace TestingRegistrationForm.Core
{
    public abstract class BaseTest
    {
        [SetUp]
        public void setUp()
        {
            WebDriverManager.SetWebDriver();
           
            NavigationHelper.Open(RegistrationDataTest.homeURL);

        }

        [TearDown]
        public void tearDown()
        {
            WebDriverManager.CloseWebDriver();
        }
    }
}


