using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    // derived classes have access to all public and protected members of base class
    // sealed classes can not be inherited from (only classes and override methods can be sealed)
    public class BaseClass
    {
        public int _publicId;
        protected int _protectedId;
        private int _privateId;
        public void WriteNum()
        {
            Console.WriteLine(12);
        }
        public static void WriteNum2()
        {
            Console.WriteLine(13);
        }

        public void WriteNum3()
        {
            Console.WriteLine(14);
        }
    }

    public class DerivedClass : BaseClass
    {
        public int _baseId;
        public new void WriteNum() // hiding the same method of base class
        {
            _protectedId++; // can access public and protected members
            _publicId++;
            WriteNum2(); // can access static and non static members in non static method
            WriteNum3();
            Console.WriteLine(42);
        }

        public static void WriteNum4()
        {
            WriteNum2(); // can access only static members in static method
            //WriteNum3(); can not access non static members in static method
            Console.WriteLine(15);
        }
    }

    internal class UseInheritance
    {
        public static void Test()
        {
            // how method hiding works
            // hiding causes confusion hence avoided, instead overriding is used
            BaseClass isReallyBase = new BaseClass();
            BaseClass isReallyDerived = new DerivedClass(); // derived class can be assigned to a base class
            DerivedClass isClearlyDerived = new DerivedClass();

            isReallyBase = isReallyDerived;
            isReallyBase = isClearlyDerived;

            isReallyBase._publicId = 1;

            isReallyDerived._publicId = 1;
            //isReallyDerived._baseId = 1; can not do this

            isClearlyDerived._publicId = 1;
            isClearlyDerived._baseId = 1;

            isReallyBase.WriteNum(); // writes 12

            isReallyDerived.WriteNum(); // writes 12

            isClearlyDerived.WriteNum(); // writes 42

        }
    }
}
