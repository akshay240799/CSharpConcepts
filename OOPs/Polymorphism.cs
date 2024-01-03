using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    // compile time polymorphism 
    // method overloading
    class MethodOverloading
    {
        // Methods can have same name as long as they have unique signature
        // Method Signature - > MethodName(datatype, datatype ,...) order of data type matters
        // Access modifier and return type does not matter
        public int Add(int a, int b) // Add(int,int)
        {
            return a + b;
        }
        public int Add(int a, int b, int c) // Add(int, int, int)
        {
            return a + b + c;
        }

        public string Add(string a, string b) // Add(string, string)
        {
            return a + b;
        }

        public string Add(string a, int b) // Add(string, int)
        {
            return "";
        }
        public string Add(int a, string b) // Add(int, string)
        {
            return "";
        }
    }

    // run time polymorphism
    // method overriding

    public class myBaseClass
    {
        // declare a virtual method in base class which can be overriden in derived classes
        // virtual methods can not be private and static
        public virtual void GetData()
        {
            Console.WriteLine("GetData from myBaseClass");
        }
        public void GetData1()
        {
            Console.WriteLine("GetData from myBaseClass");
        }
    }

    public class myDerivedClass1 : myBaseClass
    {
        // override virtual methods from base class (signature remains same only implementation changes)
        public override void GetData()
        {
            // base.GetData(); --> can call base virtual method before overriding like this
            Console.WriteLine("GetData from myDerivedClass1");
        }
    }

    public class myDerivedClass2 : myBaseClass
    {
        // override virtual methods from base class (signature remains same only implementation changes)
        public override void GetData()
        {
            Console.WriteLine("GetData from myDerivedClass2");
        }
    }

    class TestMethodOverriding
    {
        public void Test()
        {
            myBaseClass baseClass = new myBaseClass();
            myDerivedClass1 derivedClass1 = new myDerivedClass1();
            myDerivedClass2 derivedClass2 = new myDerivedClass2();

            baseClass.GetData(); // prints GetData from BaseClass
            derivedClass1.GetData(); // prints GetData from myDerivedClass1
            derivedClass2.GetData(); // prints GetData from myDerivedClass2
        }
    }

    // preventing furthur overriding for derived class
    public class X
    {
        public virtual void A()
        {
        }
    }
    public class Y : X
    {
        public sealed override void A() // using sealed keyword to stop inheritance of this method
        {
        }
    }
    public sealed class Z : Y // sealing Z will stop furthur inheritance
    {
        //public override void A() {}
        // this will not work since A() in Y is sealed
    }

    //public class K : Z {}
    //can not inherit from Z beause it is sealed
}
