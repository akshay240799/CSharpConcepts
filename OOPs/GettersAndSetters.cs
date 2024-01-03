using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class GettersAndSetters
    {
        private int _id; // this is a field.  It is private to your class and stores the actual data.
        public int Id // this is a property. Used to interact with the field without exposing the actual field.
        {
            get // getters and setters enable encapsulation, exposing the private fields using public method
            {
                Console.WriteLine("Getting Id");
                return _id; 
            }  
            set 
            {
                if (value != 0) // enables writing logic while accessing the fields
                {
                    Console.WriteLine("Setting Id");
                    _id = value; // here "value" is the new assigned value to this field.
                }
                else
                {
                    Console.WriteLine("Trying to set Id to 0");
                }
            }
        }
        public string? Name { get; set; } // this is Auto property which is similar to a private field with public default property 
        public string? DOB { get; private set; } = "01/01/2001"; // auto property with access modifier for get/set (can not be for both)
        // access modifier for property DOB is already public, so we can not have get and set private

        private string _address; // private field with custom get and set method
        public string GetAddress()
        {
            return _address;
        }
        public void SetAddress(string address)
        {
            _address = address;
        }
    }

    internal class UseGettersAndSetters
    {
        public static void Test()
        {
            Console.WriteLine("Testing Id");
            GettersAndSetters obj = new();
   
            // can not access _id because its private, instead using property Id to access _id.
            obj.Id = 1; // setting the field, value = 1 here.
            Console.WriteLine("Id = "+obj.Id); // calling get method
            obj.Id = 0; // setting to 0
            Console.WriteLine("Id = " + obj.Id);

            Console.WriteLine();

            Console.WriteLine("Testing DOB");
            Console.WriteLine("DOB Value = " + obj.DOB);
            //obj.DOB = "";
            //can not set DOB value, set method is private

            Console.WriteLine();

            Console.WriteLine("Testing Address");
            obj.SetAddress("my address");
            Console.WriteLine("Address = " + obj.GetAddress());
        }
    }
}
