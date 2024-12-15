using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new NotificationFactory3());
            customerManager.Save();
        }
    }
    //Define an interface for notifications.
    public interface INotification
    {
        void Send();
    }
    //Create concrete classes for each type of notification.
    public class EmailNotification : INotification
    {
        public void Send()
        {
            Console.WriteLine("Sending Email Notification!...");
        }
    }

    public class SmsNotification : INotification
    {
        public void Send()
        {
            Console.WriteLine("Sending SMS Notification!...");
        }
    }

    public class PushNotification : INotification
    {
        public void Send()
        {
            Console.WriteLine("Sending Push Notification!...");
        }
    }
    //Define an interface for notification factories.
    public interface INotificationFactory
    {
        INotification CreateNotification();
    }
    //Create concrete factory classes for each type of notification.
    public class NotificationFactory : INotificationFactory
    {
        public INotification CreateNotification()
        {
            return new EmailNotification();
        }
    }

    public class NotificationFactory2 : INotificationFactory
    {
        public INotification CreateNotification()
        {
            return new SmsNotification();
        }
    }

    public class NotificationFactory3 : INotificationFactory
    {
        public INotification CreateNotification()
        {
            return new PushNotification();
        }
    }
    //Create a class that uses the notification factory to send notifications.
    public class CustomerManager
    {
        private INotificationFactory _notificationFactory;
        public CustomerManager(INotificationFactory notificationFactory)
        {
            _notificationFactory = notificationFactory;
        }
        public void Save()
        {
            Console.WriteLine("Saved!...");
            INotification notification = _notificationFactory.CreateNotification();
            notification.Send();
        }
    }
}
