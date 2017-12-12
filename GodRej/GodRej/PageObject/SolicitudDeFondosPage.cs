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
    public class SolicitudDeFondosPage
    {
        
        [FindsBy(How = How.XPath, Using = "//*[@id='navbar']/ul/li[1]/a")]
        [CacheLookup]
        private IWebElement Link { get; set; }

        [FindsBy(How = How.Id, Using = "valeDescripcion")]
        [CacheLookup]
        private IWebElement Motivo { get; set; }

        [FindsBy(How = How.Id, Using = "importePeso")]
        [CacheLookup]
        private IWebElement ImporteAR { get; set; }

        [FindsBy(How = How.Id, Using = "importeUsd")]
        [CacheLookup]
        private IWebElement ImporteUSD { get; set; }

        [FindsBy(How = How.Id, Using = "fechaRendicion")]
        [CacheLookup]
        private IWebElement FechaRendicion { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='page - wrapper']/div[2]/div[1]/div/div/div[2]/div/div/div/div[2]/form/div[5]/div/button")]
        [CacheLookup]
        private IWebElement GenerarSolicitud { get; set; }


        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div[7]/button")]
        [CacheLookup]
        private IWebElement BtnCerrar { get; set; }
        
        //public void ingresarASolicitudDeFondos()
        //{
        //    BrowserFactory.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(90);
        //    Link.Click();

        //}

        public void ingresarMotivo(string motivo)
        {
            Thread.Sleep(2000);
            Motivo.SendKeys(motivo);
        }

        public void ingresarImporteEnPesos(string importeEnPesos)
        {
            ImporteAR.SendKeys(importeEnPesos);
        }

        public void ingresarImporteEnDolares(string importeEnDolares)
        {
            ImporteUSD.SendKeys(importeEnDolares);
        }

        public void ingresarFechaRendicion()
        {
            
            DateTime Hoy = DateTime.Today;
            string fechaRendicion = Hoy.ToString("dd/MM/yyyy");
            FechaRendicion.SendKeys(fechaRendicion);
        }

        public void generarSolicitud()
        {
         
            IWebElement button = BrowserFactory.Driver.FindElement(By.Id("crearSolicitud"));
            button.Click();

        }

       

        public void completarFormulario(string motivo, string importeEnPesos, string importeEnDolares)
        {
            //ingresarASolicitudDeFondos();
            DateTime Hoy = DateTime.Today;
           string fechaRendicion = Hoy.ToString("dd/MM/yyyy");

            ingresarMotivo(motivo);
            Thread.Sleep(3000);
            ingresarImporteEnPesos(importeEnPesos);
            Thread.Sleep(3000);
            ingresarImporteEnDolares(importeEnDolares);
            Thread.Sleep(3000);
            //ingresarFechaRendicion(fechaRendicion);
            Thread.Sleep(3000);
            //generarSolicitud();

        }

        public void cerrarSolicitudDeBono()
        {
            Thread.Sleep(3000);
            // BrowserFactory.Driver.FindElement(By.XPath("/html/body/div[3]/div[7]/button")).Click();
            BtnCerrar.Click();
        }

        
    }
 }