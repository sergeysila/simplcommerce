using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace PO_simplcommerce.Pages
{
    public class ProductPage : AbstractPage
    {
        public ProductPage(IWebDriver driver) : base(driver)
        {
                
        }

        public CartPage AddToCart()
        {
            driver.FindElement(By.CssSelector("div[class='product-variation '] button[class*='add-cart']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".modal-footer a")).Click();
            return new CartPage(driver);
        }
    }
}
