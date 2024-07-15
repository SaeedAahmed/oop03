
using assignmentOop03.Binding;
using assignmentOop03.Interface;
using assignmentOop03.polymorphism_overloading;

namespace assignmentOop03
{
    internal class Program
    {
        #region overloading
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static double Sum(double a, double b)
        {
            return a + b;
        }

        public static int Sum(int a, int b, int c)
        {
            return a + b;
        } 
        #endregion

        public static void ProcessEmployee(Employee employee) /*employee = new FullTimeEmployee*/
        {
            if (employee is not null)
            {
                employee.MyFun01();
                employee.MyFun02();
            }
        }

        static void Main(string[] args)
        {

            #region polymorphism

            /*
           The word Polymorphism comes from two Greek words:
          "Poly"  multiple , "Morph"  forms  
           So, simply put, it means "multiple forms." In programming, it means you can use the same method in different ways or contexts.

           In C#, we use two main concepts to achieve Polymorphism:
           Method Overloading: Creating multiple methods with the same name but different parameters.
           Method Overriding: Redefining a method that exists in the base class in the derived class.
            */
            #region overloading
            //int result = Sum(1, 2);
            //Console.WriteLine(result);
            #endregion

            #region overriding
            //typeB b = new typeB(1 , 2);
            //b.A = 2;
            //b.A = 3;
            //b.MyFun1();
            //b.MyFun2();
            #endregion

            #endregion

            #region binding
            //binding is a behaviour
            //refernce from paret = object from child
            //typeA RefBase = new typeB(1, 2);

            //RefBase.A = 11;
            // RefBase.B = 22; XXXX

            //static binding method (early binding)
            //compiler will bind function call based on referance not object
            //at compilation time
            //RefBase.MyFun1(); // i am base

            //dynamic binding method (late binding)
            //clr will bind function call based on object not refrance
            //at runtime
            // RefBase.MyFun2(); // typeB : A = 11, B = 22 
            #endregion

            #region ex --> binding is a behavior
            //FullTimeEmployee fullTimeEmployee = new FullTimeEmployee()
            //{
            //    Id = 1,
            //    Name = "saeed",
            //    Age = 25,
            //    Salary = 9_000
            //};
            //ProcessEmployee(fullTimeEmployee);

            //PartTimeEmployee partTimeEmployee = new PartTimeEmployee()
            //{
            //    Id = 1,
            //    Name = "ahmed",
            //    Age = 28,
            //    HourRate = 120
            //};
            //ProcessEmployee(partTimeEmployee);

            #endregion

            #region interface
            //A code contract is a type of agreement between the programmer who wrote the code
            //and the programmer who implements or uses it.

           // IMyFile myFile;
            ///declare for reference of type 'IMyType' , refering to null
            ///this referennce 'IMyType' can refer to an object from class or dtruct implementing the iterface
            ///clr will allocate 4 bytes at stack for the refernce


            //myFile = new IMyFile(); -->  invalide

            //MyFile myFile1 = new MyFile();
            //myFile1.Salary = 10_000;
            //myFile1.MyFun();
            ////myFile1.print(); xxxx

            ///The only way to access the default implementation of a method is to refer to
            ///the interface that contains the default implementation method, while pointing
            ///to an object from a class or struct that implements the interface

            //IMyFile referenceFormatInterface = new MyFile();
            //referenceFormatInterface.Salary = 10_000;
            //referenceFormatInterface.MyFun();
            //referenceFormatInterface.print();
            #endregion
        }
    }
}
