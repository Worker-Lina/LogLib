using Logging;
using Newtonsoft.Json;
using System;

namespace LogLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            var log = new Log();
            try
            {
                string pathToLog = $"{DateTime.Now.ToString("d")}.log";
                Console.WriteLine(pathToLog);
                int n = int.Parse(Console.ReadLine());
            }
            catch(Exception ex)
            {                
                log.Logger(ex);
            }

            string jsonTextResult = JsonConvert.SerializeObject(log);

        }
    }
}
