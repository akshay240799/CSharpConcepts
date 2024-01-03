namespace C__Basics
{
    internal class SampleClass
    {
        // readonly
        // used to declare variables whose values can be assigned at runtime but cannot be changed after that.
        // i.e. initialization at declaration is allowed and initialization at contructor is allowed.
        // readonly fields can not be changed after object creation

        public static readonly string readonlyData_static; // static readonly fields are shared between all the instances
        public readonly string readonlyData; // non static readonly fields can be different for each object
        public readonly string readonlyData_initialized = "some data"; // this can be changed in contructor

        public SampleClass()
        {
            //readonlyData_static = "some data"; error - will only work in static constructor
            readonlyData_initialized = "some data";
            readonlyData = "some data";
        }
        static SampleClass()
        {
            //readonlyData = "some data"; error - can not initialize non static member
            readonlyData_static = "some static data";
        }

        // constant
        // The value assigned to a const variable must be known at compile time.
        // i.e. declaration and initialization at the same time.
        // can not be static, but treated as static
        public const string constData = "some data";
    }

    class UsingConstAndReadonly
    {
        public static void Test()
        {
            Console.WriteLine(SampleClass.readonlyData_static); // can not be accessed using instance
            Console.WriteLine(SampleClass.constData); // can not be accessed using instance

            SampleClass sample = new(); 
            Console.WriteLine(sample.readonlyData); // only accessible using instance
        }
    }
}
