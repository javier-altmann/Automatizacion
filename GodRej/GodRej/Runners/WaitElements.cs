using GodRej.WrapperFactory;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace GodRej.Runners
{
    public static class WaitElements
    {
        public static IWebElement WaitUntilElementExists(By elementLocator, int timeout = 10)
        {
            try
            {
                var wait = new WebDriverWait(BrowserFactory.Driver, TimeSpan.FromSeconds(timeout));
                return wait.Until(ExpectedConditions.ElementExists(elementLocator));
            }
            catch (NoSuchElementException)
            {

                Console.WriteLine("Element with locator: '" + elementLocator + "' was not found in current context page.");
                throw;
            }
        }
        public static void CargarTodosLosElementos(params By[] list)
        {
            foreach (var item in list)
            {
                WaitUntilElementExists(item);
            }

        }
    }

}
  
