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
                var array = new int[10];
                var rand = new Random();
                int someNumber = 15;
                for(int i = 0; i < someNumber; i++)
                {
                    array[i] = rand.Next(20,40);
                }

            }
            catch(Exception ex)
            {                
                log.Logger(ex);
            }

            string jsonTextResult = JsonConvert.SerializeObject(log);

        }
    }
}
