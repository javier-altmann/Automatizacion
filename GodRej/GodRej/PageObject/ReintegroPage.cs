using GodRej.WrapperFactory;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GodRej.PageObject
{
   public class ReintegroPage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='navbar']/ul/li[2]/a")]
        [CacheLookup]
        private IWebElement Menu { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#page-wrapper > div.wrapper.wrapper-content > div.container > div > div > div.container > div > div > div > div.ibox-content > form > div.well > div > button")]
        [CacheLookup]
        private IWebElement AgregarReintegro { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='rendicionListado']/tbody/tr/td[1]/div/div[1]")]
        [CacheLookup]
        private IWebElement CuentaCorriente { get; set; }


        public void ingresarReintegro()
        {
            BrowserFactory.Driver.Navigate().GoToUrl("http://10.10.0.74:89/Reintegro/Reintegro");
        }

        public void agregarReintegro()
        {
            AgregarReintegro.Click();
        }

        public void agregarCuentaCorriente()
        {
            //  var test =  BrowserFactory.Driver.FindElement(By.XPath("//*[@id='rendicionListado']/tbody/tr/td[1]/div/div[1]"));
            //  test.Click();

            IWebElement EducationDropDownElement = BrowserFactory.Driver.FindElement(By.XPath("//*[@id='rendicionListado']/tbody/tr/td[1]/div/div[1]"));
            Thread.Sleep(300);
            SelectElement SelectAnEducation = new SelectElement(EducationDropDownElement);
            var test = SelectAnEducation;
            SelectAnEducation.SelectByIndex(3);

            Thread.Sleep(3000);
            //test.SendKeys("test");
           
         //   CuentaCorriente.SendKeys("Test");
        }
    }
}
