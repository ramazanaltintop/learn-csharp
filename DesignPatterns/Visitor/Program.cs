using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager { Name = "Ramazan", Salary = 25500 };
            Manager manager2 = new Manager { Name = "Trump", Salary = 20000 };

            Worker worker = new Worker { Name = "Elon", Salary = 18000 };
            Worker worker2 = new Worker { Name = "Musa", Salary = 19000 };
            Worker worker3 = new Worker { Name = "İbrahim", Salary = 18500 };

            manager.Subordinates.Add(manager2);
            manager2.Subordinates.Add(worker);
            manager2.Subordinates.Add(worker2);
            manager2.Subordinates.Add(worker3);

            OrganizationalStructure organizationalStructure = new OrganizationalStructure(manager);
            
            PayrollVisitor payrollVisitor = new PayrollVisitor();
            PayRiseVisitor payriseVisitor = new PayRiseVisitor();

            organizationalStructure.Accept(payrollVisitor);
            organizationalStructure.Accept(payriseVisitor);
        }
    }
    class OrganizationalStructure
    {
        public EmployeeBase Employee;

        public OrganizationalStructure(EmployeeBase firstEmployee)
        {
            Employee = firstEmployee;
        }

        public void Accept(VisitorBase visitor)
        {
            Employee.Accept(visitor);
        }
    }
    abstract class EmployeeBase
    {
        public abstract void Accept(VisitorBase visitor);
        public string Name { get; set; }
        public decimal Salary { get; set; }
    }
    class Manager : EmployeeBase
    {
        public List<EmployeeBase> Subordinates { get; set; }

        public Manager()
        {
            Subordinates = new List<EmployeeBase>();
        }

        public override void Accept(VisitorBase visitor)
        {
            visitor.Visit(this);

            foreach (var employee in Subordinates)
            {
                employee.Accept(visitor);
            }
        }
    }
    class Worker : EmployeeBase
    {
        public override void Accept(VisitorBase visitor)
        {
            visitor.Visit(this);
        }
    }
    abstract class VisitorBase
    {
        public abstract void Visit(Manager manager);
        public abstract void Visit(Worker worker);
    }
    class PayrollVisitor : VisitorBase
    {
        public override void Visit(Manager manager)
        {
            Console.WriteLine("{0} paid {1}", manager.Name, manager.Salary);
        }

        public override void Visit(Worker worker)
        {
            Console.WriteLine("{0} paid {1}", worker.Name, worker.Salary);
        }
    }
    class PayRiseVisitor : VisitorBase
    {
        public override void Visit(Manager manager)
        {
            Console.WriteLine("{0} salary increased to {1}", manager.Name, 
                manager.Salary * (decimal)1.2);
        }

        public override void Visit(Worker worker)
        {
            Console.WriteLine("{0} salary increased to {1}", worker.Name, 
                worker.Salary * (decimal)1.5);
        }
    }
}
