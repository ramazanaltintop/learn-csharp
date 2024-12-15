using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager manager = new CustomerManager();
            manager.Save();
        }
    }
    interface ILogging
    {
        void Log();
    }
    class Logging : ILogging
    {
        public void Log()
        {
            Console.WriteLine("Logged!...");
        }
    }
    interface ICaching
    {
        void Cache();
    }
    class Caching : ICaching
    {
        public void Cache()
        {
            Console.WriteLine("Cached!...");
        }
    }
    interface IAuthorize
    {
        void CheckUser();
    }
    class Authorize : IAuthorize
    {
        public void CheckUser()
        {
            Console.WriteLine("User checked!...");
        }
    }
    interface IValidation
    {
        void Validate();
    }
    class Validation : IValidation
    {
        public void Validate()
        {
            Console.WriteLine("Validated!...");
        }
    }
    class CrossCuttingConcernsFacade
    {
        public ILogging Logging;
        public ICaching Caching;
        public IAuthorize Authorize;
        public IValidation Validation;
        public CrossCuttingConcernsFacade()
        {
            Logging = new Logging();
            Caching = new Caching();
            Authorize = new Authorize();
            Validation = new Validation();
        }
    }
    class CustomerManager
    {
        private CrossCuttingConcernsFacade _concerns;
        public CustomerManager()
        {
            _concerns = new CrossCuttingConcernsFacade();
        }
        public void Save()
        {
            _concerns.Caching.Cache();
            _concerns.Logging.Log();
            _concerns.Authorize.CheckUser();
            _concerns.Validation.Validate();
            Console.WriteLine("Saved!...");
        }
    }
    
}
