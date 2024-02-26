using System;
using System.Threading;
using CSharpInterview.Constructors;
namespace CSharpInterview
{
    //the default scope of a C# class is internal.
    class Program
    {
        #region Delegates
        public delegate int Math(int a, int b);

        public int Add(int a, int b) { return a + b; }
        public int Mul(int a, int b) { return a * b; }
        public static int Division(int a,int b) { return a / b; }
        #endregion Delegates

        static void Main(string[] args)
        {
            //Console.WriteLine("Start");


            #region Interface

            TestInterface ti = new TestInterface();
            ITest _ITest = new TestInterface();
            _ITest.InterfaceTest();
            _ITest.SayHi("Kamal");

            ITest2 _ITest2 = new TestInterface();
            _ITest2.InterfaceTest();
            _ITest2.SayHi("Ratnakar");

            Console.WriteLine("----------------------------------------");


            #endregion Interface

            #region AbstractClass

            TestAbstract ta = new TestAbstract();
            ta.NormalorNonConcreteMethod();
            ta.AbstractMethod();
            TestAbstract ta1 = new TestAbstract(1,"kamal");
            TestAbstract2 tb2 = new TestAbstract2();
            Console.WriteLine("----------------------------------------");
            #endregion AbstractClass

            #region Constructors

            #region PrivateConstructor

            // A class whcih have Private constructor cannot be instantiated neither cannot be inherited

           // PrivateConstructor pc = new PrivateConstructor();

            #endregion PrivateConstructor

            #region StaticConstructors
            // even though we create 2 instances for Static Constructor ,
            // it will call only once that is for first static constructor instance
            StaticConstructors sc = new StaticConstructors();
            StaticConstructors sc1 = new StaticConstructors();
            Console.WriteLine("--------------------------------------------");
            #endregion StaticConstructors

            #region CopyConstructors

            CopyConstructors cc = new CopyConstructors("CopyCon", 098);
            CopyConstructors cc2 = new CopyConstructors(cc);

            Console.WriteLine(cc.ID);
            Console.WriteLine(cc.Name);

            Console.WriteLine(cc2.ID);
            Console.WriteLine(cc2.Name);
            Console.WriteLine("--------------------------------------------");

            #endregion CopyConstructors

            #region ParameterizedConstructors

            ParameterizedConstructor pc = new ParameterizedConstructor(123, "Name ParameterizedCon");
            Console.WriteLine(pc.ID);
            Console.WriteLine(pc.Name);

            ParameterizedConstructor pc2 = new ParameterizedConstructor(10000, "Different Name from  ParameterizedCon");
            Console.WriteLine(pc2.ID);
            Console.WriteLine(pc2.Name);

            ParameterizedConstructor pc1 = new ParameterizedConstructor();
            Console.WriteLine(pc1.ID);
            Console.WriteLine(pc1.Name);

            Console.WriteLine("--------------------------------------------------------");

            #endregion ParameterizedConstructors

            #region DefaultConstructor

            DefaultConstructors dc = new DefaultConstructors();
            DefaultConstructors dc1 = new DefaultConstructors();
            Console.WriteLine(dc.Id);
            Console.WriteLine(dc.Name);
            Console.WriteLine(dc1.Id);
            Console.WriteLine(dc1.Name);
            Console.WriteLine("--------------------------------------------------------");
            #endregion DefaultConstructor

            #endregion Constructors

            #region Delegates1
            Program p = new Program();
            Math add = new Math(p.Add);
          
            add += new Math(p.Mul);
            add += new Math(Program.Division);

            add(10, 20);
            #endregion Delegates1

            #region Singleton
            Thread t1 = new Thread(() => { TestSingleton("Kamal"); });
            t1.Name = "TKamal";
            Thread t2 = new Thread(() => { TestSingleton("Ratnakar"); });
            t2.Name = "TRatnakar";

            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();

            Console.WriteLine(Thread.CurrentThread.Name);
            #endregion Singleton

            Console.ReadLine();
        }

        #region Singleton1
        public static void TestSingleton (string value)
        {
            var singletonObj = Singleton.GetInstnace(value);
            Console.WriteLine(singletonObj.Value);
        }
        #endregion Singleton1
    }

    #region PrivateConstructor1
    // A class whcih have Private constructor cannot be instantiated neither cannot be inherited
    //public class TestPrivateConstructor : PrivateConstructor
    //{

    //}
    #endregion PrivateConstructor1
}
