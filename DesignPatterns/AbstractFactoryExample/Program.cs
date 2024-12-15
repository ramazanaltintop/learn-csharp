using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new HPFactory());
            productManager.GetAll();
        }
    }

    public abstract class Device
    {
        public abstract void GetDetails();
    }

    //Lenovo Devices
    public class LenovoMobile : Device
    {
        public override void GetDetails()
        {
            Console.WriteLine("Lenovo Mobile!...");
        }
    }

    public class LenovoLaptop : Device
    {
        public override void GetDetails()
        {
            Console.WriteLine("Lenovo Laptop!...");
        }
    }

    public class LenovoDesktop : Device
    {
        public override void GetDetails()
        {
            Console.WriteLine("Lenovo Desktop!...");
        }
    }

    //HP Devices
    public class HPMobile : Device
    {
        public override void GetDetails()
        {
            Console.WriteLine("HP Mobile!...");
        }
    }
    public class HPLaptop : Device
    {
        public override void GetDetails()
        {
            Console.WriteLine("HP Laptop!...");
        }
    }
    public class HPDesktop : Device
    {
        public override void GetDetails()
        {
            Console.WriteLine("HP Desktop!...");
        }
    }

    //IBM Devices
    public class IBMMobile : Device
    {
        public override void GetDetails()
        {
            Console.WriteLine("IBM Mobile!...");
        }
    }
    public class IBMLaptop : Device
    {
        public override void GetDetails()
        {
            Console.WriteLine("IBM Laptop!...");
        }
    }
    public class IBMDesktop : Device
    {
        public override void GetDetails()
        {
            Console.WriteLine("IBM Desktop!...");
        }
    }

    //Apple Devices
    public class AppleMobile : Device
    {
        public override void GetDetails()
        {
            Console.WriteLine("Apple Mobile!...");
        }
    }
    public class AppleLaptop : Device
    {
        public override void GetDetails()
        {
            Console.WriteLine("Apple Laptop!...");
        }
    }
    public class AppleDesktop : Device
    {
        public override void GetDetails()
        {
            Console.WriteLine("Apple Desktop!...");
        }
    }

    public abstract class DeviceFactory
    {
        public abstract Device CreateMobile();
        public abstract Device CreateLaptop();
        public abstract Device CreateDesktop();
    }

    public class LenovoFactory : DeviceFactory
    {
        public override Device CreateDesktop()
        {
            return new LenovoDesktop();
        }

        public override Device CreateLaptop()
        {
            return new LenovoLaptop();
        }

        public override Device CreateMobile()
        {
            return new LenovoMobile();
        }
    }

    public class HPFactory : DeviceFactory
    {
        public override Device CreateDesktop()
        {
            return new HPDesktop();
        }

        public override Device CreateLaptop()
        {
            return new HPLaptop();
        }

        public override Device CreateMobile()
        {
            return new HPMobile();
        }
    }

    public class IBMFactory : DeviceFactory
    {
        public override Device CreateDesktop()
        {
            return new IBMDesktop();
        }

        public override Device CreateLaptop()
        {
            return new IBMLaptop();
        }

        public override Device CreateMobile()
        {
            return new IBMMobile();
        }
    }

    public class AppleFactory : DeviceFactory
    {
        public override Device CreateDesktop()
        {
            return new AppleDesktop();
        }

        public override Device CreateLaptop()
        {
            return new AppleLaptop();
        }

        public override Device CreateMobile()
        {
            return new AppleMobile();
        }
    }

    public class ProductManager
    {
        private DeviceFactory _deviceFactory;

        private Device _deviceDesktop;
        private Device _deviceLaptop;
        private Device _deviceMobile;

        public ProductManager(DeviceFactory deviceFactory)
        {
            _deviceFactory = deviceFactory;
            _deviceDesktop = _deviceFactory.CreateDesktop();
            _deviceLaptop = _deviceFactory.CreateLaptop();
            _deviceMobile = _deviceFactory.CreateMobile();
        }
        public void GetAll()
        {
            _deviceDesktop.GetDetails();
            _deviceLaptop.GetDetails();
            _deviceMobile.GetDetails();
            Console.WriteLine("Products listed!...");
        }
    }
}
