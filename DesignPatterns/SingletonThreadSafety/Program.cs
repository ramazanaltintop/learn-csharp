using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonThreadSafety
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
        private static readonly Lazy<ConfigurationManager> _configurationManager = 
            new Lazy<ConfigurationManager>(() => new ConfigurationManager());
        private ConfigurationManager()
        {
            
        }
        public static ConfigurationManager CreateAsSingleton()
        {
            return _configurationManager.Value;
        }
        public void Save()
        {
            Console.WriteLine("Saved!...");
        }
    }
}
