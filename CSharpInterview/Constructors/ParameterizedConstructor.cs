using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterview.Constructors
{
    // A constructor with at least one parameter is called a parameterized constructor.
    // The advantage of a parameterized constructor is that you can initialize
    // each instance of the class with a different value.
    class ParameterizedConstructor
    {
        public int ID; 
        public string Name;
        public ParameterizedConstructor( int id,  string name) {
            ID = id;
            Name = name;
        }
        public ParameterizedConstructor()
        {
            ID = 321;
            Name = "Name from DefaltCon";
        }
    }
}
