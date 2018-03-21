using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_simplcommerce
{
    public abstract class BaseTest
    {
        protected IWebDriver driver;
        protected string baseUrl = "http://demo.simplcommerce.com/";

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
        }
    
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
