using Ocaramba;
using Ocaramba.Extensions;
using Ocaramba.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAutomationFramework.Framework.Frontend.Pages.Wikipedia
{
    class Wikipedia_contentpage : AbstractPage
    {
        readonly ElementLocator FIRST_HEADING = new ElementLocator(Locator.Id, "firstHeading");


        public Wikipedia_contentpage(DriverContext driverContext) : base(driverContext)
        {

        }

        public bool CheckIfFirstHeadingMatchesTerm(string term)
        {
            return Driver.GetElement(FIRST_HEADING).GetTextContent().Contains(term);
        }
    }
}
