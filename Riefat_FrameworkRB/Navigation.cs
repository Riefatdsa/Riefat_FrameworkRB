using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.IO;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Riefat_FrameworkRB
{
    class Navigation
    {
        public static void NavigateVia(IWebDriver driver, ControlsFactory sLocator, string sContainer)
        {
            IWebElement navBox = driver.FindElement(By.Id(sContainer));
            IList<IWebElement> navList = navBox.FindElements(By.XPath(".//li")).ToList<IWebElement>();

            //foreach (IWebElement i in navList)
            //{
            //    string[] stringSeparators = new string[] { "\r\n" };
            //    string menuIndex = i.Text;
            //    if (menuIndex.Equals("DropDown Menu"))
            //    {
            //        string[] lines = menuIndex.Split(stringSeparators, StringSplitOptions.None);
            //        IWebElement itemToClick = null;
            //        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //        itemToClick = DynamicLocator.imageIndex(lines[0], driver);
            //        //itemToClick = DynamicLocator.imageIndex("DropDown Menu", driver);
            //        itemToClick.Click();
            //    }
            //}

        }
    }
}
