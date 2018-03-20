using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_simplcommerce.Pages
{
    public abstract class AbstractPage
    {
        protected IWebDriver driver;

        public AbstractPage(IWebDriver driver)
        {
            this.driver = driver;
        }


    }
}
