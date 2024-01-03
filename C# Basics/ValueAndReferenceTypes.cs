using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Basics
{
    internal class ValueAndReferenceTypes
    {
        public static void ValueType()
        {
            // value types - int, float, bool, enum...etc (anything that is not ref type)
            // generally stored on stack, stores actual value
            Console.WriteLine("Value Type Example");
            int i = 5; // stores i in memory at some location
            int j = i; // stores j in memory at different location
            j = 10; // set a new value to j, changing value of j's location without affecting i
            Console.WriteLine($"i = {i}, j = {j}");
            Console.WriteLine($"initial i = {i}"); // i is 5
            Square(i); // this method creates a new i and sets it to 25.
            Console.WriteLine($"final i = {i}"); // i here still remains 5
        }
        public static void Square(int i)
        {
            i = i * i; // set value of i to square of i, this creates a new value of i at another location in the memory.
            // which means i here is different than the i outside of this method, both are stored at two separate location in the memory.
            Console.WriteLine($"i in square method = {i}"); // i here is 25
        }

        public static void ReferenceType()
        {
            // reference types - string, array, class, object, delegates
            // stores values on heap, stores referece to the value on stack
            Console.WriteLine("Reference Type Example (for lists)");
            List<int> list = [1,2,3];
            Console.WriteLine($"List Count = {list.Count}");
            ChangeList(list);
            Console.WriteLine($"List Count = {list.Count}");

            Console.WriteLine("Value Type Example (for strings)");
            // strings are immutable, which means whenever a string is modified new string is created with new value. 
            string name1 = "OriginalName";
            string name2 = name1;
            Console.WriteLine(name1); // stores OrignialName
            Console.WriteLine(name2); // stores OrignialName
            // upto this point both name1 and name2 refers/points to same location in memeory
            name1 = "NewName";
            // modification of name1 creates a new reference for name1, because of which name1 changes but name2 remains same.
            Console.WriteLine(name1); // stores NewName
            Console.WriteLine(name2); // stores OrignialName
        }
        public static void ChangeList(List<int> list)
        {
            list.Add(4); // changing this affects the original list outside this method.
        }
    }
}
