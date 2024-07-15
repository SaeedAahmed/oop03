using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentOop03.Interface
{
    //Devloper 02
    internal class MyFile : IMyFile /* -->implement */
    {
        private int salary;

        public int Salary { get; set; }
         
        public void MyFun()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
