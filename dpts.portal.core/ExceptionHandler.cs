using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dpts.portal.core
{
    public class ExceptionHandler
    {
        /// <summary>
        /// Logs Exception into file
        /// </summary>
        /// <param name="ex">Exception</param>
        public static void HandleException(Exception ex)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter(ConfigurationManager.AppSettings["logDirectory"]);
            file.WriteLine(ex.StackTrace);
        }
    }
}