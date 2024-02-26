using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterview
{
    public abstract class AbstractClass
    {
        public int id;
        public string name;
        public AbstractClass()
        {
            Console.WriteLine("AbstractClass Constructor Called !");
        }
        public AbstractClass(int id, string name)
        {
            this.id = id;
            this.name = name;
            Console.WriteLine("AbstractClass parameterized Constructor is Called !" + this.id.ToString() + " " + this.name);
        }

        public void NormalorNonConcreteMethod()
        {
            Console.WriteLine("Normal or Non Concrete Method is Called !");
        }

         public abstract void AbstractMethod();

    }

    public class TestAbstract : AbstractClass
    {
        public TestAbstract() 
        {
            Console.WriteLine("Derived Class Constructor is called !");
        }
        public TestAbstract(int id, string name) : base(id, name)
        {

            Console.WriteLine("Derived Class Parameterized Constructor is calling  AbstractClass Parameterized Constrcutor! : " + id.ToString() + " "+ name);
        }
       
        public override void AbstractMethod()
        {
            Console.WriteLine("AbstractMothod is being orverriden by Derivied Class");
        }
        
    }
    public class TestAbstract2 : TestAbstract
    {
        public TestAbstract2()
        {
            Console.WriteLine("Derived Class  TestAbstract2  Constructor is called !");
        }
    }

    
}
