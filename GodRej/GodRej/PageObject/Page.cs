using GodRej.WrapperFactory;
using OpenQA.Selenium.Support.PageObjects;
using System;


namespace GodRej.PageObject
{
    public static class Page
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(BrowserFactory.Driver, page);
            return page;
        }


        public static SolicitudDeFondosPage SolicitudDeFondos
        {
            get
            {
                return GetPage<SolicitudDeFondosPage>();
            }
        }

        public static ReintegroPage Reintegro
        {
            get
            {
                return GetPage<ReintegroPage>();
            }
        }
    }
}
