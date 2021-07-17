using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
/* Author: Riefat Dollie
 * Module: Page Factory in conjunction with the POM
 * Descr: This module stores the WebElement Identifiers for the respective controls
 * Date:  16/07/2021
 *  */

namespace Riefat_FrameworkRB
{
    class ControlsFactory
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='gallery']")]
        public IWebElement ClickPhotoList { get; set; }

        [FindsBy(How = How.XPath, Using = "//html/body/div[1]/ul/li")]
        public IWebElement ClickImageIndex1 { get; set; }

        // [FindsBy(How = How.XPath, Using = "/html/body/div[1]/ul/li")]
        // public IWebElement ClickImageIndex2 { get; set; }

        //[FindsBy(How = How.XPath, Using = "/html/body/div[1]/ul/li")]
        //public IWebElement ClickImageIndex3 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div")]
        public IWebElement ClickTrash { get; set; }

        //[FindsBy(How = How.XPath, Using = "//*[@text() ='DropDown Menu']")]
        [FindsBy(How = How.XPath, Using = "//*[@id='menu-item-2803']")]
        public IWebElement DropDownMenu { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div[1]/div[2]/div/div/div[2]/div/div/div[1]/p/iframe")]
        public IWebElement FindiFrame { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div[1]/div[2]/div/div/div[2]/div/div/div/p/select")]
        public IWebElement ddlCountrySelector { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/header/div[2]/div/div/div[3]/div/ul/li[4]")]
        public IWebElement MenuItemTester { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/header/div[2]/div/div/div[3]/div/ul/li[4]/div/ul/li[3]")]
        public IWebElement SubMenuSampleTest { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div[1]/div[2]/div/div/div[2]/div[1]/form/p/span/input")]
        public IWebElement btnChooseFile { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div[1]/div[2]/div/div/div[2]/div[2]/form/div[1]/input")]
        public IWebElement txtEnterName { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div[1]/div[2]/div/div/div[2]/div[2]/form/div[2]/input")]
        public IWebElement txtEnterEmail { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div[1]/div[2]/div/div/div[2]/div[2]/form/div[3]/input")]
        public IWebElement txtEnterWebsite { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div[1]/div[2]/div/div/div[2]/div[2]/form/div[4]/select")]
        public IWebElement ddlExperience { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div[1]/div[2]/div/div/div[2]/div[2]/form/div[5]/label[2]/input")]
        public IWebElement chkFunctional { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div[1]/div[2]/div/div/div[2]/div[2]/form/div[5]/label[3]/input")]
        public IWebElement chkAutomation { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div[1]/div[2]/div/div/div[2]/div[2]/form/div[5]/label[4]/input")]
        public IWebElement chkManual { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div[1]/div[2]/div/div/div[2]/div[2]/form/div[6]/label[2]/input")]
        public IWebElement rbGraduate { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div[1]/div[2]/div/div/div[2]/div[2]/form/div[6]/label[3]/input")]
        public IWebElement rbPostGraduate { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div[1]/div[2]/div/div/div[2]/div[2]/form/div[6]/label[4]/input")]
        public IWebElement rbOther { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div[1]/div[2]/div/div/div[2]/div[2]/form/div[7]/textarea")]
        public IWebElement txtAreaComment { get; set; }

        [FindsBy(How = How.ClassName, Using = "pushbutton-wide")]
        public IWebElement btnSubmitForm { get; set; }
    }
}
