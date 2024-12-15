using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new Log4NetAdapter());
            productManager.Save();
        }
    }
    interface ILogger
    {
        void Log(string message);
    }
    class RALogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Logged with RALogger!..., {message}!...");
        }
    }

    //Nuget'ten indirildiğini düşünelim
    //DLL
    //Değiştiremiyoruz.
    class Log4Net
    {
        public void LogMessage(string message)
        {
            Console.WriteLine("Logged with log4net!..., {0}", message);
        }
    }

    class ProductManager
    {
        private ILogger _logger;
        public ProductManager(ILogger logger)
        {
            _logger = logger;
        }
        public void Save()
        {
            _logger.Log("User Data");
            Console.WriteLine("Saved!...");
        }
    }

    class Log4NetAdapter : ILogger
    {
        public void Log(string message)
        {
            Log4Net log4net = new Log4Net();
            log4net.LogMessage(message);
        }
    }
}
