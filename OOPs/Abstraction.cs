using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    /*
    Can not create objects of the abstract class.
    Can not declare the abstract methods outside the abstract class.
    Can not declare an abstract class as Sealed Class.
    Can not declare an abstract class as Static Class.
     */

    // abstract class is generally used as base class, where derived classes must implement/override abstract methods declared in base class
    internal abstract class MyAbstractClass
    {
        private int _id;
        public void myMethod1()
        {
            Console.WriteLine("Executing my method 1");
        }
        public static void myMethod2()
        {
            Console.WriteLine("Executing my static method 3");
        }
        // abstract methods do not have any implementation
        // must be inside a abstract class
        // abstract methods can not be private or static
        public abstract void myMethod3(); // No implementation
    }

    internal class MyNormalClass
    {
        // can not declare an abstract method in non abstract class!
        // public abstract void myMethod2(); -- this will result in compilation error
    }

    internal class MyDerivedClass : MyAbstractClass // can only inherit 1 class
    {
        // must implement abstract methods from base class
        public override void myMethod3() // same as abstract method declared in base class with implementation
        {
            Console.WriteLine("Executing my method 2");
        }
    }

    internal class UseAbstraction
    {
        public void Test()
        {
            // can not create an instance of abstract class
            //MyAbstractClass myAbstractClass = new MyAbstractClass();

            MyDerivedClass derivedClass = new MyDerivedClass();
            derivedClass.myMethod3(); 
            derivedClass.myMethod1();

            // can use static methods directly (without instance)
            MyAbstractClass.myMethod2();
            MyDerivedClass.myMethod2();

            // abstraction allows derived classes to inherit non abstract methods and override abstract methods from the base class
        }
    }
}
