using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Basics
{
    // structs are similar to class but are value types.
    // used to encapsulates data and related functionality.
    // typically used for small, lightweight objects that are better suited to being passed by value.

    internal struct DataStruct
    {
        private int _id;
        public int Id { get { return _id; } }
        public void SetId(int id)
        {
            _id = id + 1000;
        }
    }

    internal class DataClass
    {
        private int _id;
        public int Id { get { return _id; } }
        public void SetId(int id)
        {
            _id = id + 1000;
        }
    }
    class UsingStructs
    {
        public static void Test()
        {
            DataStruct originalData = new();
            originalData.SetId(5);

            DataStruct newData = originalData;
            newData.SetId(10); // creates new MyStruct in memory with new data

            Console.WriteLine(originalData.Id); // returns 1005
            Console.WriteLine(newData.Id); // returns 1010

            // same using class
            DataClass originalData1 = new();
            originalData1.SetId(5);

            DataClass newData1 = originalData1; // creates new references
            newData1.SetId(10); // updates value for all references

            Console.WriteLine(originalData1.Id); // returns 1010
            Console.WriteLine(newData1.Id); // returns 1010

        }
    }
}
