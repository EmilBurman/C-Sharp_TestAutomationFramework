using Ocaramba;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAutomationFramework.Framework.Frontend.Pages
{
    public partial class AbstractPage
    {
        public AbstractPage(DriverContext driverContext)
        {
            this.DriverContext = driverContext;
            this.Driver = driverContext.Driver;
        }

        protected IWebDriver Driver { get; set; }

        protected DriverContext DriverContext { get; set; }
    }
}
