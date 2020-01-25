using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Employee
    {
        private int Id;
        private string Name;
        private string DepartmentName;

        public delegate void OnFired(string message);
        public event OnFired EventFired;

        public Employee(int identificator, string naam, string depname)
        {
            this.Id = identificator;
            this.Name = naam;
            this.DepartmentName = depname;
        }
        public int GetId()
        {
            EventFired("GetId()ethod called");
            return this.Id;
        }
        public string GetName()
        {
            EventFired("GetName() Method is called");
            return this.Name;
        }

        public string GetDepartmentName()
        {
            EventFired("GetDepartmentName() Method is called");
            return this.DepartmentName;
        }

        public void update(int id)
        {
            EventFired("update() Method is called");
            this.Id = id;
        }

        public void update(String naam)
        {
            EventFired("update() Method is called");
            this.Name = naam;
        }

        public void updateDepName(String depname)
        {
            EventFired("updateDepName() Method is called");
            this.DepartmentName = depname;
        }
    }
}
