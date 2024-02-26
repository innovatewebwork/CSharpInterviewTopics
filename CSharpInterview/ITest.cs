using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterview
{
    public interface ITest
    {
        //int a; Interface cannot contain instance fields
        //public void Test(){   } does not support default interface implementation
        // public abstract void Test(); modifier abstract is not valid for this item

        void InterfaceTest();
        void SayHi(string name);

    }
    public interface ITest2
    {
        void InterfaceTest();
        void SayHi(string name);
    }
    public class TestInterface : ITest, ITest2
    {
        void ITest.InterfaceTest()
        {
            Console.WriteLine("ITest InterfaceTest is called after being inherited to TestInterface class");
        }
        void ITest2.InterfaceTest()
        {
            Console.WriteLine("ITest2 InterfaceTest is called after being inherited to TestInterface class");
        }

        public void SayHi(string name)
        {
            Console.WriteLine("Hi, from InterfaceTest Mr." + name);
        }
    }

    public abstract class InterfaceWithAbstract : ITest, ITest2
    {
       
        public void SayHi(string name)
        {
            Console.WriteLine("Hi, from InterfaceTest Mr." + name);
        }

        public abstract void InterfaceTest();

        
    }
}
