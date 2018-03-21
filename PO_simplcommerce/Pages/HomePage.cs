using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace PO_simplcommerce.Pages
{
    public class HomePage : AbstractPage      
    {
        private string url;

        public HomePage(IWebDriver driver, string url) : base(driver)
        {
            this.url = url;
        }

        public HomePage Open()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            return this;
        }

        public ProductPage ChoseSmartphone()
        {
            driver.FindElements(By.CssSelector(".product-list>div")).Last().FindElement(By.TagName("a")).Click();
            return new ProductPage(driver);
        }
    }
}
