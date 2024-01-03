using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Basics
{
    // static members belong to class itself instead of an instance
    // when a member is declared as static, it means there is only one instance of that member shared among all instances of the class
    internal static class StaticClass
    {
        // everyting in this must be static
    }

    // static memebers can be directly accessed using class name without any instance
    // instances can not use static members
    internal class StaticMemebersClass
    {
        private int _value; // can be different for each instance
        private static int _staticValue; // value belongs to class, same value shared everywhere at a time

        public StaticMemebersClass() // default constructor 
        {
            _staticValue = 20; // has access to both static and not static fields
            _value = 1;
        }

        static StaticMemebersClass() // static constructor
        {
            // executes only once in entire application lifecyle when class is used first. 
            _staticValue = 10; // has access to only static fields
        }
        public int GetValue()
        {
            _staticValue = 30; // has access to both static and not static fields
            return _value;
        }
        public static int GetValueStatic()
        {
            return _staticValue; // has access to only static fields
        }
    }

    class UseStaticMembers
    {
        public static void Test()
        { 
            Console.WriteLine(StaticMemebersClass.GetValueStatic()); // static constructor is called
                                                                     // static value is set to 10 

            StaticMemebersClass obj1 = new(); // default constructor is called
                                              // static value is set to 20
            Console.WriteLine(StaticMemebersClass.GetValueStatic());

            //obj1.GetValueStatic() can not access static member using instance
            Console.WriteLine(obj1.GetValue()); // static value is set to 30
            Console.WriteLine(StaticMemebersClass.GetValueStatic());

            StaticMemebersClass obj2 = new(); // default constructor is called
            Console.WriteLine(StaticMemebersClass.GetValueStatic()); // static value set back to 20
        }
    }
}
