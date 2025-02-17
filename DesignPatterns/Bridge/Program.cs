﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.MessageSenderBase = new SmsSender();
            customerManager.UpdateCustomer();
        }
    }
    class Body
    {
        public string Title { get; set; }
        public string Text { get; set; }
    }
    abstract class MessageSenderBase
    {
        public void Save()
        {
            Console.WriteLine("Message saved!...");
        }
        public abstract void Send(Body body);
    }

    class EmailSender : MessageSenderBase
    {
        public override void Send(Body body)
        {
            Console.WriteLine("{0} was sent via EmailSender!...", body.Title);
        }
    }
    class SmsSender : MessageSenderBase
    {
        public override void Send(Body body)
        {
            Console.WriteLine("{0} was sent via SmsSender!...", body.Title);
        }
    }
    class CustomerManager
    {
        public MessageSenderBase MessageSenderBase { get; set; }
        public void UpdateCustomer()
        {
            MessageSenderBase.Send(new Body { Title = "About the Course"});
            Console.WriteLine("Customer updated!...");
        }
    }
}
