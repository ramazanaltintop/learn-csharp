﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customerObserver = new CustomerObserver();
            ProductManager productManager = new ProductManager();
            productManager.Attach(customerObserver);
            productManager.Attach(new EmployeeObserver());
            productManager.Detach(customerObserver);
            productManager.UpdatePrice();
        }
    }
    class ProductManager
    {
        List<Observer> _observers = new List<Observer>();
        public void UpdatePrice()
        {
            Notify();
            Console.WriteLine("Product price updated!...");
        }
        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }
        public void Detach(Observer observer)
        {
            _observers.Remove(observer);
        }
        private void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }
    }
    abstract class Observer
    {
        public abstract void Update();
    }
    class CustomerObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Message to customer : Product price updated!...");
        }
    }
    class EmployeeObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Message to employee : Product price updated!...");
        }
    }
}
