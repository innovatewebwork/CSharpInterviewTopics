using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterview.Constructors
{
    class StaticConstructors
    {
        //  static constructor must be parameterless
        static StaticConstructors()
        {
            Console.WriteLine("Static Constructor is being called ");
        }
    }
}
