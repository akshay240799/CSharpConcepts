using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    // Total 5 types of constructors
    // Default, Parameterized, Copy, Static, Private
    internal class Product
    {
        public int _id;
        public string? _name;
        public static int? _count;

        public Product() // Default Constructor
        {
            // No parameters and automatically provided by the compiler if no other constructor is defined.
            // used to initialize the object with default values.
            // if provided then will be called by default whenever a new instace of this class is created
            Console.WriteLine("Using Default Constructor");
            _id = 0; //sets id of all product objects to 0 by default
        }

        public Product(string name) // Parameterized Constructor
        {
            // default constructor that takes parameters.
            // allows you to initialize the object with specific values.
            Console.WriteLine("Using Parameterized Constructor");
            _id = 0;
            _name = name; // set name field to provided value.
        }

        public Product(Product product) // Copy Constructor
        {
            // takes object as parameter
            // returns a copy of the passed object
            Console.WriteLine("Using Copy Constructor");
            _id = product._id;
            _name = product._name;
        }

        static Product() // Static Constructor
        {
            // always parameter less and has no access modifiers
            // called automatically by the runtime before any static members are accessed or any static methods are called.
            Console.WriteLine("Using Static Constructor"); // only visible once before any instance of this class is created 
            _count = 0; // set this static count to 0
        }

        public static void AStaticMethod()
        {
            Console.WriteLine("Using a static method");
            Console.WriteLine("count = " + _count); // observe the value of count
            _count++; Console.WriteLine("Updating counter");
            Console.WriteLine("count = " + _count);
        }
    }
    internal class ProductSingleton
    {
        private static ProductSingleton instance; // a field to store an instance of this class
        private int _id;
        private ProductSingleton() // Private Constructor
        {
            // can not be called outside this class, which means no instances can be created outside
            // instead the instance/object is created in a class member and retured to caller.
            // some initialization code here
            Console.WriteLine("Using Private Constructor");
            _id = 0;
        }

        public static ProductSingleton Instance // A property which creates and returns an instance
        {
            get
            {
                if (instance == null) // allowing only 1 instance at a time (singleton pattern)
                {
                    instance = new ProductSingleton(); // private constructor is called
                }
                return instance;
            }
        }

        public static ProductSingleton GetInstance() // a simple method which returns an instance
        {
            instance = new ProductSingleton(); // private constructor is called
            return instance;
        }
    }

    internal class TestConstructorTypes
    {
        public static void Run()
        {
            Console.WriteLine("Creating new instance of Product Class");
            Product product1 = new Product(); // default constructor
            Console.WriteLine($"Product 1 details: Id = {product1._id}, Name = {product1._name}");
            Console.WriteLine();
            Product product2 = new Product("myProduct"); // parameterized
            Console.WriteLine($"Product 2 details: Id = {product2._id}, Name = {product2._name}");
            Console.WriteLine();
            Product product3 = new Product(product2); // copy
            Console.WriteLine($"Product 3 details: Id = {product3._id}, Name = {product3._name}");
            Console.WriteLine();

            Console.WriteLine("Using a static method or member of Product Class");
            Console.WriteLine("Value of counter = "+ Product._count);
            Product.AStaticMethod(); 
            Console.WriteLine("Value of counter = " + Product._count);
            Product.AStaticMethod();
            Console.WriteLine("Value of counter = " + Product._count);
            Console.WriteLine();

            Console.WriteLine("Creating instance of ProductSingleton");
            // only way to get product singleton is using class static members
            ProductSingleton productSingleton1 = ProductSingleton.Instance; // using property
            ProductSingleton productSingleton2 = ProductSingleton.GetInstance(); // using method
        }
    }
}
