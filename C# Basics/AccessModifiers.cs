using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Basics
{
    // classes can only be public or internal
    public class AccessClass_InBasics
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
}
