using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterview
{
    //    Why do we need delegates in C#?
    //C# programmers often need to pass a method as a parameter of other methods when dealing with events.
    //For this purpose, we create and use delegates in C#.
    //A delegate is a class that encapsulates a method signature.
    //Although it can be used in any context, it often serves as the basis for the event-handling model in C# and .NET.
    //One good way of understanding delegates is by thinking of a delegate as something that gives a name to a method signature.



    //Provides a good way to encapsulate the methods.
    //Delegates are mainly used in implementing the call-back methods and events.
    //Delegates can be chained together as two or more methods can be called on a single event.
    //Delegates are the library class in System namespace.
    //These are the type-safe pointer of any method.
    //It doesn’t care about the class of the object that it references.
    //Delegates can also be used in “anonymous methods” invocation.
    //Anonymous Methods(C# 2.0) and Lambda expressions(C# 3.0) are compiled to delegate types in certain contexts.
    //Sometimes, these features together are known as anonymous functions.
  
}
