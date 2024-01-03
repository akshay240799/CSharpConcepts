using C__Basics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    // classes can only be public or internal
    public class AccessClass_InOOPs
    {
        // public
        // can be accessed anywhere
        // access - anywhere
        public string? _publicData;

        // internal
        // can be accessed anywhere in current assembly/project
        // access - this assembly
        internal string? _internalData;

        // protected
        // can be accessed ONLY in this class and its child classes
        // access - this class + derived/child class (any assembly)
        protected string? _protectedData;

        // protected
        // can be accessed ONLY in this assembly and its child classes in any assembly
        // access - this assembly + derived class (any assembly)
        protected internal string? _protectedInternalData;

        // protected
        // can be accessed ONLY in this class and its child classes in current assembly
        // access - this class + derived class (this assembly)
        private protected string? _privateProtectedData;

        // private
        // can be accessed ONLY in this class
        private string? _privateData;
        
    }

    public class SampleClass
    {
        public void Test() // not inheriting from any AccessClass
        {
            AccessClass_InBasics anotherAssemblyClass = new();
            AccessClass_InOOPs sameAssemblyClass = new();

            // can only access public data
            anotherAssemblyClass._publicData = null;

            // can access following data
            sameAssemblyClass._publicData = null;
            sameAssemblyClass._internalData = null;
            sameAssemblyClass._protectedInternalData = null;
        }
    }

    // A child class inheriting from same AccessClass from c# Basics project
    // i.e. derived from class in different assembly
    public class ChildClass1 : AccessClass_InBasics
    {
        // can access public, protected and protected internal data
        public void Test()
        {
            var childClass = new ChildClass1();
            childClass._publicData = null; 
            childClass._protectedInternalData = null; 
            childClass._protectedData = null; 
        }
    }

    // derived from AccessClass in this assembly
    public class ChildClass2 : AccessClass_InOOPs
    {
        // can access public, protected, protected internal and private protected data
        public void Test()
        {
            var childClass = new ChildClass2();
            childClass._publicData = null;
            childClass._protectedInternalData = null;
            childClass._protectedData = null;
            childClass._privateProtectedData = null;
        }
    }
}
