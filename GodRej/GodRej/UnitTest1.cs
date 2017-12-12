using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using GodRej.WrapperFactory;
using System.Configuration;
using System.Threading;
using FrameworkAT.Helpers;
using GodRej.Autenticacion;
using GodRej.PageObject;

namespace GodRej
{
    [TestClass]
    public class UnitTest1
    {
        public void LogIn()
        {

            BrowserFactory.InitBrowser("Chrome");

            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL_QA_GODREJ"]);
            Thread.Sleep(2000);
            Autenticacion.AutenticacionApp.autenticacionGodrej();
            Thread.Sleep(3000);


        }

        [TestMethod]
        public void IngresoCorrectoALaApp()
        {
            var dir = AppDomain.CurrentDomain.BaseDirectory + @"\..\..\Logs\";

            LogHelper.CreateLogFile(dir);

            LogIn();

            LogHelper.Write("Se logueo el usuario");

            Thread.Sleep(3000);



        }

        [TestMethod]
        public void IngresoCorrecto()
        {
            var dir = AppDomain.CurrentDomain.BaseDirectory + @"\..\..\Logs\";

            LogHelper.CreateLogFile(dir);

            LogIn();

            LogHelper.Write("Se logueo el usuario");

            Thread.Sleep(5000);

            //Page.SolicitudDeFondos.ingresarASolicitudDeFondos();
            BrowserFactory.Driver.Navigate().GoToUrl("http://10.10.0.74:89/ValeTesoreria/Solicitud");
            LogHelper.Write("Ingreso a la página Solicitud ");
            //Page.SolicitudDeFondos.completarFormulario("prueba automation – generar vale", "1520,01", "1700,99");

            Page.SolicitudDeFondos.ingresarMotivo("prueba automation – generar vale");

            Page.SolicitudDeFondos.ingresarImporteEnPesos("1520,01");
            LogHelper.Write("Ingresa importe en pesos");

            Page.SolicitudDeFondos.ingresarImporteEnDolares("1700,99");
            LogHelper.Write("Ingresa importe en dolares");

            Thread.Sleep(3000);
            Page.SolicitudDeFondos.ingresarFechaRendicion();
            LogHelper.Write("Ingresa fecha de rendicion");

            Page.SolicitudDeFondos.generarSolicitud();
            LogHelper.Write("Presiona en botón generar solicitud ");
            Thread.Sleep(3000);
            
            Page.SolicitudDeFondos.cerrarSolicitudDeBono();
            LogHelper.Write("Presiona cerrar en Popup de confirmación");

            LogHelper.Write("-- FIN DEL TEST --");



        }

        [TestMethod]
        public void ReintegroTestCorrecto()
        {
            var dir = AppDomain.CurrentDomain.BaseDirectory + @"\..\..\Logs\";

            LogHelper.CreateLogFile(dir);

            LogIn();

            LogHelper.Write("Se logueo el usuario");

            Thread.Sleep(5000);

            Page.Reintegro.ingresarReintegro();
            Thread.Sleep(4000);
            Page.Reintegro.agregarReintegro();

            Page.Reintegro.agregarCuentaCorriente();

            BrowserFactory.Driver.FindElement(By.XPath("//*[@id='rendicionListado']/tbody/tr/td[1]/div/div[1]")).Click();
            
        }

    }
}
