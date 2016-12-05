using System;
using System.Configuration;

namespace Dpts.Web.Core
{
    public class ExceptionHandler
    {
        /// <summary>
        /// Logs Exception into file
        /// </summary>
        /// <param name="ex">Exception</param>
        public static void WriteExceptionToFile(Exception ex)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter(ConfigurationManager.AppSettings["logDirectory"]);
            file.WriteLine(ex.StackTrace);
        }

        /// <summary>
        /// Logs Exception into Database
        /// </summary>
        /// <param name="ex">Exception</param>
        public static void HandleException(Exception ex)
        {
        }
    }
}