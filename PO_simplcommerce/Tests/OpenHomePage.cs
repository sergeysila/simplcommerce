using NUnit.Framework;
using PO_simplcommerce.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_simplcommerce.Tests
{
    class OpenHomePage : BaseTest
    {
        [Test]
        public void AddToCartTest()
        {
            HomePage homePage = new HomePage(driver, baseUrl);
            ProductPage productPage = homePage
                .Open()
                .ChoseSmartphone();
            CartPage cartPage = productPage.AddToCart();
        }
    }
}
