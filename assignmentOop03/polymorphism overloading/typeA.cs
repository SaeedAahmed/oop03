using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentOop03.polymorphism_overloading
{
    internal class typeA
    {
        public int A { get; set; }

        public typeA(int _A)
        {
            A = _A;
        }

        public void MyFun1()
        {
            Console.WriteLine("i am base");
        }
        public virtual void MyFun2()
        {
            Console.WriteLine($"TypeA : A = {A}");
        }
    }

    class typeB : typeA
    { 
    
        public int B { get; set; }

        public typeB(int _A , int _B) :base(_A)
        {
            B = _B;   
        }

        /// Apllay function overriding using "new" keyword
        public new void MyFun1() // new version from myfun1 method
        {
            Console.WriteLine("i am child");
        }

        /// Apllay function overriding using "override" keyword  
        ///But befor anything , the function that will be overrided using "override" keyword , must be public virtual
        public override void MyFun2()
        {
            Console.WriteLine($"typeB : A = {A} , B ={B}");
        }
    }
}
