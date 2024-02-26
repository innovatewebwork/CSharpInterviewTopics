using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterview
{
    public sealed class SingletonUsingLazy
    {
        private static Lazy<SingletonUsingLazy> _lazy = new Lazy<SingletonUsingLazy>(() => new SingletonUsingLazy());
        private SingletonUsingLazy() { }

        public static SingletonUsingLazy Instance
        {
            get
            {
               return _lazy.Value;
            }
        }
    }
}
