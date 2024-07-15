using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentOop03.Binding
{
    internal class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }

        public void MyFun01()
        {
            Console.WriteLine("i am employee");
        }
        public virtual void MyFun02()
        {
            Console.WriteLine($"ID = {Id} , Name = {Name}, Age = {Age}");
        }

    }

    class FullTimeEmployee : Employee
    {
        public decimal Salary { get; set; }

        public new void MyFun01()
        {
            Console.WriteLine("i am full time employee");
        }
        public override void MyFun02()
        {
            Console.WriteLine($"Full time employee : ID = {Id} , Name = {Name}, Age = {Age} salary = {Salary:c}");
        }
    }

    class PartTimeEmployee : Employee
    {
        public decimal HourRate { get; set; }

        public new void MyFun01()
        {
            Console.WriteLine("i am part time employee");
        }
        public override void MyFun02()
        {
            Console.WriteLine($"part time employee : ID = {Id} , Name = {Name}, Age = {Age} Hour Rate = {HourRate:c}");
        }
    }
}
