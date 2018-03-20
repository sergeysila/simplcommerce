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
        public void OpenHPTest()
        {
            HomePage hp = new HomePage(driver, baseUrl);
            hp.Open();
        }
    }
}
