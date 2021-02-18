using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Logging
{
    public class Log
    {
        public string Message { get; set; }
        public Type TypeMessage { get; set; }
        public string Level { get; set; }


        private string PathToLog { get; set; }


        public void Logger(Exception ex)
        {
            Message = ex.Message;
            PathToLog = $"{DateTime.Now.ToString("d")}.log";

            using (StreamWriter streamWriter = new StreamWriter(PathToLog, true, System.Text.Encoding.Default))
            {
                string logInformation = $"{DateTime.Now.ToString("G")}, {ex.TargetSite.DeclaringType}, {ex.TargetSite.Name}, {ex.Message}";
                streamWriter.WriteLine(logInformation);
            }
        }

        public void Logger(string message, Exception ex)
        {
            Message = message;
            PathToLog = $"{DateTime.Now.ToString("d")}.log";

            using (StreamWriter streamWriter = new StreamWriter(PathToLog, true, System.Text.Encoding.Default))
            {
                string logInformation = $"{DateTime.Now.ToString("G")}, {ex.TargetSite.DeclaringType}, {ex.TargetSite.Name}, {message}";
                streamWriter.WriteLine(logInformation);
            }
        }

        public void Info()
        {
            PathToLog = $"{DateTime.Now.ToString("d")}.log";

            using (StreamWriter streamWriter = new StreamWriter(PathToLog, true, System.Text.Encoding.Default))
            {
                string logInformation = $"{DateTime.Now.ToString("G")}, {Message}";
                streamWriter.WriteLine(logInformation);
            }
        }
    }
}
