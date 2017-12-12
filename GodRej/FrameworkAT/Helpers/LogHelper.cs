using System;
using System.IO;


namespace FrameworkAT.Helpers
{
   public class LogHelper
    {

        //Global
        private static string _logFileName = string.Format("{0:yyyymmddhhmmss}", DateTime.Now);
        private static StreamWriter _streamw = null;


        //Crea un archivo para almacenar las acciones
        public static void CreateLogFile(string dir)
        {
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);

            }

            _streamw = File.AppendText(dir + _logFileName + ".log");
        }

        //Metodo para escribir en el archivo 
        public static void Write(string logMessage)
        {
            _streamw.Write("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            _streamw.WriteLine("    {0}", logMessage);
            _streamw.Flush();
        }

        public static void Close()
        {
            _streamw.Close();
        }
    }
}
