using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterview.Constructors
{
    class PrivateConstructor
    {
        // A class whcih have Private constructor cannot be instantiated neither cannot be inherited
        private PrivateConstructor()
        {
            Console.WriteLine("Private Constructor is being called");
        }
    }

    public sealed class SealedPrivateConstructor
    {
        // A class whcih have Private constructor cannot be instantiated neither cannot be inherited
        private SealedPrivateConstructor()
        {
            Console.WriteLine("Sealed class Private Constructor Constructor is being called");
        }
    }
}
