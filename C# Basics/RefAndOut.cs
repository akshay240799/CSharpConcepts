using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Basics
{
    public class RefAndOut
    {
        public static void Ref() 
        {
            Console.WriteLine("Ref keyword");

            // ref keywords marks parameter passed as reference, ref parameter must be initialized
            int i = 2; // value needs to be initialized in order to pass as a referece
            //int i; -- this will throw compiler error
            Console.WriteLine($"Original i = {i}");
            Double(i);
            Console.WriteLine($"Final i = {i}"); // i still remains 2 because it is a value type.

            Console.WriteLine("Now using ref");
            Console.WriteLine($"Original i = {i}");
            RefDouble(ref i); // by passing i as ref parameter it behaves as a reference type
            Console.WriteLine($"Final i = {i}"); // i changes to 4
        }
        public static void Double(int i)
        {
            i = i * 2;
        }
        public static void RefDouble(ref int i)
        {
            i = i * 2;
        }

        public static void Out()
        {
            Console.WriteLine("Out keyword");

            // out keyword is similar as ref keyword, but out paramter can not be initialized.
            int i; // only declaration no initialization
            //int i = 2; -- this will throw compiler error

            Console.WriteLine($"Original i is unassigned");
            OutMethod(out i); // this method initalizes i 
            Console.WriteLine($"Final i = {i}"); // i is assigned to 2 then changed to 4
        }
        public static void OutMethod(out int i)
        {
            i = 2; // out paramter must be initialized without this will get compiler error
            Console.WriteLine($"Initialized i = {i}");
            i = 4;
        }

        public static void In()
        {
            Console.WriteLine("In keyword");

            int i = 2; // value needs to be initialized in order to pass as a referece
            //int i; -- this will throw compiler error

            Console.WriteLine($"Original i = {i}");
            InMethod(in i); // this method can not modify i
            Console.WriteLine($"Final i = {i}"); // i always remains same as original
        }
        public static void InMethod(in int i)
        {
            // i must be used as readonly, or will get compiler error
            int j = i * 2;
        }
    }
}
