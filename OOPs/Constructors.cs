using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class User
    {
        public int _id;
        public string? _name;

        public User() { Console.WriteLine("Using default constructor in User"); } // default constructor, invoked when using - new User();
        // You can use this to set some default values for the object
        public User(int id) // constructor which take a parameter as input and returns a User object
        {
            Console.WriteLine("Using Id constructor in User");
            this._id = id; // input can be used in some logic
        }
        public User(string name) : this(0) // here this(0) calls constructor in this class which take int paramter 
        {
            Console.WriteLine("Using Name constructor in User"); // this line will executer after this(0)
            _name = name;
        }
        public User(int id, string name) : this() // calling default constructor 
        {
            Console.WriteLine("Using Id and Name constructor in User");
            this._id = id;
            _name = name;
        }
    }

    internal class ChildUser : User
    {
        public int _childId;
        public ChildUser(int childId) // this will call the default constructor of the base class first
        {
            Console.WriteLine("Using ChildId constructor in ChildUser");
            _childId = childId;
        }
        public ChildUser(int id, int chidId) : base(id) // calling specific constructor of the base class
        {
            // here we are setting the value of _id for this ChildUser using base(id)
            Console.WriteLine("Using Id and ChildId constructor in ChildUser");
            
            _childId = chidId;
        }
    }
    internal class UseConstructors
    {
        public static void Test()
        {
            Console.WriteLine("Testing User Constructors");
            User user = new User(); // default
            var user1 = new User(10); // single parameter
            var user2 = new User("user2"); // single paramter but inside it calls id constructor first and sets id value to 0
            var user3 = new User(11,"user3"); // multi paramter

            Console.WriteLine();

            Console.WriteLine("Testing ChildUser Constructors");
            //ChildUser childUser = new ChildUser(); will not work since no default constructors for this class
            var childUser1 = new ChildUser(100);
            var childUser2 = new ChildUser(10,101); // calls base class id constructor first 
        }
    }
}
