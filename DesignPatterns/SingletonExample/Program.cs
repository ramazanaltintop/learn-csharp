using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var configurationManager = ConfigurationManager.CreateAsSingleton();
            configurationManager.Save();
        }
    }
    public class ConfigurationManager
    {
        private static ConfigurationManager _configurationManager;
        private ConfigurationManager()
        {

        }
        public static ConfigurationManager CreateAsSingleton()
        {
            if (_configurationManager == null)
            {
                _configurationManager = new ConfigurationManager();
            }
            return _configurationManager;
        }
        public void Save()
        {
            Console.WriteLine("Saved!...");
        }
    }
}
