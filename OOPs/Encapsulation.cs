using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    //The primary goal of encapsulation is to hide the internal implementation details of an object 
    // This is done using access modifiers and properties
    // For example, make sensitive fields as private expose a public method through which it can be accessed.
    internal class EncapsulatedClass
    {
        private int _id;
        private string _data;
        private int _count;
        public string Data // encapsulation using properties or getter and setter
        {
            get
            {
                // can add some layers around _data
                if (_id != 0)  
                {
                    return _data;
                }
                return _data = "";
            }
            set
            {
                if (_data != "some condition")
                {
                    _data = value;
                }
            }
        }

        public int Count { get; private set; } // this prevents modifying count but allows reading

        // can be done using public methods
        public int GetId()
        {
            if(_id != 0)
            {
                return _id;
            }
            return _id = 5;
        }

        public void SetId(int id)
        {
            if(_id != 5)
            {
                _id = id;
            }

        }
    }

}
