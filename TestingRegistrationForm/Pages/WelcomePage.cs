using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingRegistrationForm.Core;

namespace TestingRegistrationForm.Pages
{
    public class WelcomePage : BasePage
    {
        By WelcomePageLocator = By.XPath("//h1[contains(text(),'WELCOME')]");
        By InboxButtonLocator = By.XPath("//label[@class='title']");

        public WelcomePage()
       {
           WaitPageLoaded(WelcomePageLocator, 3000, "Welcome Page ");
       }
        public void ClickInbox()
        {
            Element.WaitUntilDisplayed(InboxButtonLocator, 3000);
            Element.Click(InboxButtonLocator);
        }
    }
}
