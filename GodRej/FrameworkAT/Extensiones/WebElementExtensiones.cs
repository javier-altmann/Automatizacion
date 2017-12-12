using FrameworkAT.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;


namespace FrameworkAT.Extensiones
{
     public static class WebElementExtensiones
    {
        
        //Da el text de un elemento
        public static string GetLinkText(this IWebElement element)
        {
            return element.Text;
        }


        public static void SelectDropDownList(this IWebElement element, string value)
        {
            SelectElement ddl = new SelectElement(element);
            ddl.SelectByText(value);
        }

        public static void SelectDropDownList(this IWebElement element,int value)
        {
            SelectElement ddl = new SelectElement(element);
            ddl.SelectByIndex(value);
        }


        public static void Hover(this IWebElement element)
        {
           
            Actions actions = new Actions(IniciarTest.Driver);
            actions.MoveToElement(element).Perform();
        }

        //Revisa si un elemento esta presente 
        private static bool IsElementPresent(IWebElement element)
        {
            try
            {
                bool ele = element.Displayed;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //Revisa si un elemento está presente 
        public static void AssertElementPresent(this IWebElement element)
        {
            if (!IsElementPresent(element))
                throw new Exception(string.Format("El elemento no esta presente"));
           
        }

      
    }
}
