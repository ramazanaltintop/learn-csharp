using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new NLogger());
            customerManager.Save();

            CustomerManagerTests customerManagerTests = new CustomerManagerTests();
            customerManagerTests.SaveTest();
        }
    }
    class CustomerManager
    {
        private ILogger _logger;

        public CustomerManager(ILogger logger)
        {
            _logger = logger;
        }
        public void Save()
        {
            _logger.Log();
            Console.WriteLine("Saved!...");
        }
    }
    interface ILogger
    {
        void Log();
    }
    class Log4NetLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged with Log4NetLogger!...");
        }
    }
    class NLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged with NLogger!...");
        }
    }
    class StubLogger : ILogger
    {
        private static StubLogger _stubLogger;
        private static object _lockObject = new object();

        private StubLogger()
        {

        }
        public static StubLogger GetLogger()
        {
            if (_stubLogger == null)
            {
                lock (_lockObject)
                {
                    if (_stubLogger == null)
                    {
                        _stubLogger = new StubLogger();
                    }
                }
            }
            return _stubLogger;
        }
        public void Log()
        {
            
        }
    }
    class CustomerManagerTests
    {
        public void SaveTest()
        {
            CustomerManager customerManager = new CustomerManager(StubLogger.GetLogger());
            customerManager.Save();
        }
    }
}
