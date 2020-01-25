using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Id:");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Your Name:");
            string naam = Console.ReadLine();

            Console.WriteLine("Enter Your DepartmentName:");
            string Depname = Console.ReadLine();

            Employee emp = new Employee(id, naam, Depname);
            emp.EventFired += new Employee.OnFired(occured);


            Console.WriteLine("Employee Details ");
            Console.WriteLine("Employee ID : " +emp.GetId());
            Console.WriteLine("Employee name : " + emp.GetName());
            Console.WriteLine("Employee Department Name : " + emp.GetDepartmentName());

            emp.update(3000);
            emp.update("Rythm");
            emp.updateDepName("Managing");

            Console.WriteLine("Updated Employee details : ");
            Console.WriteLine("Employee ID : " + emp.GetId());
            Console.WriteLine("Employee Name :" + emp.GetName());
            Console.WriteLine("Employee Department Name :  " + emp.GetDepartmentName());

            void occured(string str)
            {
                Console.WriteLine($"{str}");
            }
        }
    }
}
