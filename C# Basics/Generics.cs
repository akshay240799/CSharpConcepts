using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Basics
{
    // Generics is used to write classes, structures, methods, and interfaces with placeholder types
    // that are specified when the code is instantiated.
    // represented by <> at the end.
    internal class GenericClass<T>
    {
        private T genericField;
        public GenericClass(T value)
        {
            genericField = value;
        }
        public T GetValue() 
        {
            return genericField;
        }
    }
    internal class GenericMethod
    {
        // Generic method that swaps the values of two variables
        public static (T,T) Swap<T>(T a, T b)
        {
            // can not perform any specific operations on a and b since their data type is not known.
            // see Constrains.cs for further info
            T temp = a;
            a = b;
            b = temp;
            return (a,b);
        }
    }

    interface IGenericInterface<T>
    {
        T getData();
    }
    class MyClass : IGenericInterface<string>
    {
        public string getData()
        {
            return "";
        }
        public void Test()
        {
            // Instantiate the generic class as int
            GenericClass<int> genericClass1 = new GenericClass<int>(10);
            var value1 = genericClass1.GetValue(); // here value1 is int

            // Instantiate the generic class as string
            GenericClass<string> genericClass2 = new GenericClass<string>("hello");
            var value2 = genericClass2.GetValue(); // here value2 is string

            // Using Generic method
            GenericMethod.Swap<int>(4, 8); // can be simplified like below
            GenericMethod.Swap(4, 8);
            GenericMethod.Swap("string1", "string2");
        }
    }
}
