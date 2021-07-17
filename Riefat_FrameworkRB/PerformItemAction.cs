/* Author: Riefat Dollie
 * Module: PerformItemAction.cs
 * Descr: This module uses the Actions Class to perform specified actions such as Hover and Dragging of controls.
 * Date:  16/07/2021
 *  */
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;



namespace Riefat_FrameworkRB
{
    class PerformItemAction
    {
        public void PerformItemActions(IWebElement onWebElement, IWebElement toWebElement, IWebDriver idriver, string sWorkFlowType)
        {
            Actions objectAction = new Actions(idriver);

            objectAction.ClickAndHold(onWebElement);

            switch (sWorkFlowType)
            {
                case "Select":
                    idriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                    break;
                case "DragDrop":
                    // new WebDriverWait(idriver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementExists(By.XPath(onWebElement.ToString())));
                    Thread.Sleep(20);
                    //dragDrop.Perform();
                    objectAction.DragAndDrop(onWebElement, toWebElement).Build().Perform();
                    objectAction.Release(toWebElement);
                    break;
                case "Hover":
                    objectAction.MoveToElement(onWebElement).Perform();
                    System.Threading.Thread.Sleep(4000);
                    break;

            }
        }
    }
}
