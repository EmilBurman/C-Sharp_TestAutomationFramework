using Ocaramba;
using Ocaramba.Extensions;
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

        public bool Open()
        {
            string url = BaseConfiguration.GetUrlValue;
            Driver.NavigateTo(new Uri(url));
            return Driver.GetElement(LOGO).Displayed;
        }

        public void SearchForTerm(string term)
        {
            Driver.GetElement(SEARCH_FIELD).SendKeys(term);
            Driver.GetElement(SEARCH_BUTTON).Click();
        }
    }
}
