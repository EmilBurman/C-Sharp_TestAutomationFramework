using Ocaramba;
using Ocaramba.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAutomationFramework.Framework.Frontend.Pages.Wikipedia
{
    class Wikipedia_startpage : AbstractPage
    {
        readonly ElementLocator LOGO = new ElementLocator(Locator.Id, "p-logo");
        readonly ElementLocator SEARCH_FIELD = new ElementLocator(Locator.Id, "searchInput");
        readonly ElementLocator SEARCH_BUTTON = new ElementLocator(Locator.Id, "searchButton");

        public Wikipedia_startpage(DriverContext driverContext): base(driverContext)
        {

        }
    }
}
