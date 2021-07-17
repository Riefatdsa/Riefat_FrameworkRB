/* Author: Riefat Dollie
 * Module: Web Flow Execution Steps
 * Descr: This module is instructed to call the relevant steps in the sequence provided by the dataset/array
 * Date:  16/07/2021
 *  */
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
using System.Threading;
using NUnit.Framework;

namespace Riefat_FrameworkRB
{
    class WebFlowExecution
    {
        public static void webStepExecutor(string sAction, IWebDriver idriver, ControlsFactory sLocator, string sfilepath) //, string sElementID)
        {
            PerformItemAction performAction = new PerformItemAction();

            switch (sAction)
            {
                case "Interact Menu":
                    Thread.Sleep(5000);
                    sLocator.DropDownMenu.Click();
                    break;
                case "Navigate":
                    //Navigation.NavigateVia(idriver, sLocator); //, sElementID);
                    break;
                case "Select Menu":
                    //Hover over the Tester Menu
                    performAction.PerformItemActions(sLocator.MenuItemTester, null, idriver, "Hover");
                    Thread.Sleep(5000);
                    // sLocator.MenuItemtTester.Click();
                    break;
                case "SubMenu":
                    //Hoover over the Sample Test Page menu item
                    performAction.PerformItemActions(sLocator.SubMenuSampleTest, null, idriver, "Hover");
                    Thread.Sleep(5000);
                    //Select the Sample Test Page sub menu item
                    sLocator.SubMenuSampleTest.Click();
                    break;
                case "DragDrop":
                    //Utility.WaitUntilElementVisible(pfLocator.ClickImageIndex1, TimeSpan.FromSeconds(10));
                    idriver.SwitchTo().ParentFrame();
                    idriver.SwitchTo().Frame(sLocator.FindiFrame);

                    IWebElement temp = idriver.FindElement(By.XPath("/html/body/div[1]/ul"));
                    List<IWebElement> list = temp.FindElements(By.XPath(".//li")).ToList<IWebElement>();
                    list.Count();

                    DynamicLocator dynamic = new DynamicLocator();

                    foreach (IWebElement i in list)
                    {
                        Thread.Sleep(3000);
                        string[] stringSeparators = new string[] { "\r\n" };
                        string test = i.Text;
                        string[] lines = test.Split(stringSeparators, StringSplitOptions.None);
                        PerformItemAction performAct = new PerformItemAction();
                        IWebElement imageClic = null;
                        //idriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                        imageClic = DynamicLocator.imageIndex(lines[0], idriver);
                        performAct.PerformItemActions(imageClic, sLocator.ClickTrash, idriver, "DragDrop");
                        Thread.Sleep(5000);
                    }
                    break;
                case "Selector":
                    Thread.Sleep(5000);
                    SelectElement SelectCountry = new SelectElement(sLocator.ddlCountrySelector);
                    SelectCountry.SelectByText("Antarctica");
                    break;
                case "EnterPageInfo":
                    //select an image
                    sLocator.btnChooseFile.SendKeys(sfilepath + "ProfilePic.jpg");
                    //Assert.IsTrue(sLocator.btnChooseFile.Text.Contains("ProfilePic.jpg"));
                    sLocator.txtEnterName.SendKeys("Peter");
                    sLocator.txtEnterName.SendKeys(Keys.Tab);
                    sLocator.txtEnterEmail.SendKeys("test@1.com");
                    sLocator.txtEnterEmail.SendKeys(Keys.Tab);
                    sLocator.txtEnterWebsite.SendKeys("https://www.globalsqa.com/samplepagetest/");
                    SelectElement SelectExperience = new SelectElement(sLocator.ddlExperience);
                    SelectExperience.SelectByValue("1-3");
                    sLocator.chkAutomation.Click();
                    sLocator.rbPostGraduate.Click();
                    sLocator.txtAreaComment.SendKeys("Enter Comment info");
                    Thread.Sleep(5000);
                    sLocator.btnSubmitForm.Click();
                    break;
            }
        }
    }
}
