using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Basics
{
    internal class AsyncMethods
    {
        public static async Task CallAnAsyncMethods()
        {
            Stopwatch sw = new Stopwatch();
            Console.WriteLine("With Await.."); // calling both methods with Async, executes one after other
            sw.Start();
            await AsyncMethod1();
            await AsyncMethod2();
            sw.Stop();
            Console.WriteLine("Total Time for both methods:" + sw.Elapsed); // takes almost 4secs 
            Console.WriteLine();

            Console.WriteLine("Without Await.."); // calling both methods without Async, executes parallelly
            sw.Restart();
            sw.Start();
            Task<string> runMethod1 = AsyncMethod1(); //create tasks for both to have control on each task
            Task<string> runMethod2 = AsyncMethod2();
            Task.WaitAll(runMethod1,runMethod2); // use created tasks to wait for a specific task
            sw.Stop();
            Console.WriteLine("Total Time for both methods:" + sw.Elapsed); // takes almost 2 secs

            string s1 = runMethod1.Result; // use created tasks to get results
            string s2 = runMethod2.Result;

            //another way of doing same
            //List<Task> tasks = new List<Task> {AsyncMethod1(), AsyncMethod2() };
            //await Task.WhenAll(tasks);
        }

        public static async Task<string> AsyncMethod1()
        {
            Console.WriteLine("AsyncMethod1 - 1");
            await Task.Delay(1000); // causing delay in this task
            Console.WriteLine("AsyncMethod1 - 2");
            await Task.Delay(1000);
            Console.WriteLine("AsyncMethod1 - 3");
            return "method1 return";
        }
        public static async Task<string> AsyncMethod2()
        {
            Console.WriteLine("AsyncMethod2 - 1");
            await Task.Delay(1000);
            Console.WriteLine("AsyncMethod2 - 2");
            await Task.Delay(1000);
            Console.WriteLine("AsyncMethod2 - 3");
            return "method2 return";
        }
    }
}
