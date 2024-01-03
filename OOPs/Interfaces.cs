using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    // Can not create instance of an interface
    internal interface Interface1
    {
        // can not declare fields in interface, interface only contains the contract not actual data
        //public int _id;

        // all members in interface are by default public and can not be private
        public int Id { get; set; }

        public void Method1();
        public void Method2();
    }

    internal interface Interface2
    {
        public string Name { get; set; }

        public void Method1();
        public void Method3();
    }

    internal class MyClass : Interface1, Interface2 // can implement multiple interfaces
    {
        // must implement all methods from interfaces
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Method2()
        {
            Console.WriteLine("method 2 implementation");
        }

        public void Method3()
        {
            Console.WriteLine("method 3 implementation");
        }

        // Explicit interface implementation

        // since both the interfaces contains method1 we can explicitly create method1 for each interface
        // these methods are by default private and has no access modifiers
        // these can only be accessed through an instance of the class if cast to that interface.
        void Interface1.Method1()
        {
            Console.WriteLine("method 1 for interface 1");
        }

        void Interface2.Method1()
        {
            Console.WriteLine("method 1 for interface 2");
        }
    }

    class UseInterface
    {
        public static void Test()
        {
            MyClass obj1 = new MyClass();
            obj1.Method2();
            obj1.Method3();
            //obj1.Method1(); can not access method 1 implicitly

            Interface1 obj2 = new MyClass(); // instance of the class is cast to an interface explicitly
            obj2.Method1(); // method 1 for interface 1 
            obj2.Method2();

            Interface2 obj3 = new MyClass();
            obj3.Method1(); // method 1 for interface 2
            obj3.Method3();

        }
    }
}
