using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.IO;
using OpenQA.Selenium.Chrome;
using System.Threading;
using NUnit.Framework;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
/* Author: Riefat Dollie
 * Module: GlobalTestClass.cs
 * Descr: This nunit module performs the Setup, Tear Down and Test Case Executions.
 * Date:  16/07/2021
 *  */

namespace Riefat_FrameworkRB
{
    [TestFixture]
    public class GlobalTestClass
    {
        static string filePath = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.FullName, "Resources\\");
        static string workingDirectory = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.FullName, "Resources\\");//Environment.CurrentDirectory;
        static IWebDriver driver = new ChromeDriver(workingDirectory);
        static ControlsFactory pfLocator = new ControlsFactory();
        static string[] webFlows = new string[] { "DragDrop", "Interact Menu", "Selector", "Select Menu", "SubMenu", "EnterPageInfo" }; //, "SelectMenu"};
        ExtentReports extentReport = null;
        ExtentTest Logtest = null;

        [SetUp]
        public void SetUp()
        {
            BaseSetup setup = new BaseSetup(driver);
            PageFactory.InitElements(driver, pfLocator);
        }

        [OneTimeSetUp]
        public void ExtentReportStart()
        {
            extentReport = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(workingDirectory + "demo1.html");
            extentReport.AttachReporter(htmlReporter);
        }

        [OneTimeTearDown]
        public void ExtentReportClose()
        {
            extentReport.Flush();
        }


        [Test]
        public void DragDrop()
        {
            //Logtest = extentReport.CreateTest("Perform Drag Drop").Info("Test Drag Drop");
            WebFlowExecution.webStepExecutor(webFlows[0], driver, pfLocator, filePath);
            Thread.Sleep(3000);
            //Logtest.Log(Status.Info, "Perform Drag Drop");
            //Logtest.Log(Status.Pass, "Pass");
            //Assert.Pass("Perform Drag Drop");

        }

        [Test]
        public void SelectCountryDropDown()
        {
            //Logtest = extentReport.CreateTest("Perform DDL Selection").Info("Test Selector");
            WebFlowExecution.webStepExecutor(webFlows[1], driver, pfLocator, filePath);
            Thread.Sleep(5000);
            WebFlowExecution.webStepExecutor(webFlows[2], driver, pfLocator, filePath);
            Thread.Sleep(5000);
            //Logtest.Log(Status.Info, "Perform DDL Selection");
            //Logtest.Log(Status.Pass, "Pass");
            //Assert.Pass("Perform DDL Selection Pass");
        }

        [Test]
        public void SamplePageDataCapture()
        {
            //Logtest = extentReport.CreateTest("Perform Menu Navigation").Info("Test Menu");
            WebFlowExecution.webStepExecutor(webFlows[3], driver, pfLocator, filePath);
            Thread.Sleep(3000);
            //Logtest.Log(Status.Info, "Perform Menu Selection");

            //Logtest = extentReport.CreateTest("Perform Sub Menu Selection").Info("Test Sub Menu");
            WebFlowExecution.webStepExecutor(webFlows[4], driver, pfLocator, filePath);
            Thread.Sleep(3000);
            //Logtest.Log(Status.Info, "Perform Menu Selection");

            //Logtest = extentReport.CreateTest("Perform Data Capture").Info("Test Data Capture");
            WebFlowExecution.webStepExecutor(webFlows[5], driver, pfLocator, filePath);
            Thread.Sleep(3000);
            //Logtest.Log(Status.Info, "Perform Data Capture");
            //Logtest.Log(Status.Pass, "Pass");
            //Assert.Pass("Perform Data Capture Pass");
        }
    }


}
