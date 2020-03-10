using System;
using System.Collections.Generic;
using System.Text;

namespace TestAutomationFramework.Framework.API.Services.Misc
{
    class OmdbApiTerms
    {
        // Possible search types
        public static string SEARCH = "s";
        public static string ID = "i";
        public static string TITLE = "t";

        // Possible entertainment formats
        public static string MOVIE = "movie";
        public static string SERIES = "series";
        public static string EPISODE = "episode";

        // Possible plot formats
        public static string SHORT_PLOT = "short";
        public static string FULL_PLOT = "full";


        // Possible plot formats
        public static string JSON_DATATYPE = "json";
        public static string XML_DATATYPE = "xml";

        public static string PAGE = "page";
    }
}
