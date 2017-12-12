using System.Configuration;
using AutoItX3Lib;

namespace GodRej.Autenticacion
{
    public class AutenticacionApp
    {

        public static void autenticacionGodrej()
        {
            AutoItX3 AutoIT = new AutoItX3();
      
           
             AutoIT.Send(ConfigurationManager.AppSettings["USUARIO"] + "{TAB}");
             AutoIT.Send(ConfigurationManager.AppSettings["CONTRASEÑA"] + "{Enter}");

        }
    }
}
