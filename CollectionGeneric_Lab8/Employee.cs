using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionGeneric_Lab8
{
    internal class Employee
    {
        //Static ID with default value in ordet to give unique number to each instance.
        private static int _id = 100;
        public int ID { get; init; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }

        //Constructor with default values
        public Employee(string name = "empty", string gender = "unknown", int salary = 0)
        {
            this.ID = ++_id;
            this.Name = name;
            this.Gender = gender;
            this.Salary = salary;
        }

        //Overriding the ToString method to choose what is printed out when object is called.
        public override string ToString()
        {
            return $"ID: [{ID}] Name: [{Name}] Gender: [{Gender}] Salary: [{Salary}]";
        }
    }
}
