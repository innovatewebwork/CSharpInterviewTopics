using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterview.Constructors
{

    //    Copy Constructor in C#
    //    The constructor which creates an object by copying variables from another object is called a copy constructor.
    //    The purpose of a copy constructor is to initialize a new instance to the values of an existing instance.

    class CopyConstructors
    {
        public string Name;
        public int ID;
        public CopyConstructors(CopyConstructors copycon)
        {
            Name = copycon.Name;
            ID = copycon.ID;
        }
        public CopyConstructors(string name, int id)
        {
            ID = id;
            Name = name;
        }
    }
}
