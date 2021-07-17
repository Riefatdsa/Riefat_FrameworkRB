using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;

namespace Riefat_FrameworkRB
{
    class DynamicLocator
    {
        //public static IWebElement imageIndex(int i, IWebDriver idriver)
        //{
        //    string sXpath = "//html/body/div[1]/ul/li[" + i + "]";
        //    IWebElement imageIndx = idriver.FindElement(By.XPath(sXpath));
        //    return imageIndx;
        //}

        public static IWebElement imageIndex(string iText, IWebDriver idriver)
        {
            string sText = iText;
            IWebElement imageIndx = idriver.FindElement(By.XPath("//*[text() = '" + iText + "']"));
            return imageIndx;
        }
    }
}
