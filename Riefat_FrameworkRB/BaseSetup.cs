using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.IO;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System.Threading;

namespace Riefat_FrameworkRB
{
    class BaseSetup
    {
        public BaseSetup(IWebDriver idriver)
        {
            idriver.Navigate().GoToUrl("https://www.globalsqa.com/demo-site/draganddrop/");
            Thread.Sleep(10);
            idriver.Manage().Window.Maximize();
            Thread.Sleep(10);
        }
    }
}
