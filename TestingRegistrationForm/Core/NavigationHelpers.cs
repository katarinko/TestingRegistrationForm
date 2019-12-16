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
using System.Collections.ObjectModel;
using OpenQA.Selenium.Interactions;


namespace TestingRegistrationForm.Core
{
    public class NavigationHelper
    {

        public static void Open(String url)
        {
            WebDriverManager.GetWebDriver().Navigate().GoToUrl(url);
           

        }

        public static void Close()
        {
            WebDriverManager.CloseWebDriver();
        }
    }
}

