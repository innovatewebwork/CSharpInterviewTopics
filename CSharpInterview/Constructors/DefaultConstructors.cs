
namespace CSharpInterview.Constructors
{

    //    What is a constructor in C#?
    //A special method of the class that is automatically invoked when an instance of the class is created is called a constructor.
    //The main use of constructors is to initialize the private fields of the class while creating an instance for the class.
    //When you have not created a constructor in the class, the compiler will automatically create a default constructor of the class.
    //The default constructor initializes all numeric fields in the class to zero and all string and object fields to null.

    //Some of the key points regarding constructor are:

    //A class can have any number of constructors.
    //A constructor doesn't have any return type, not even void.
    //A static constructor can not be a parametrized constructor.
    //Within a class, you can create one static constructor only.




    //What is a constructor ?
    //A constructor is a special method that invokes automacally and initializes the fields of the class whenever the instace gets created

    //What is a default constructor ?
    //    A constructor without any parameters is called a default constructor;
    //    in other words, this type of constructor does not take parameters.
    //    The drawback of a default constructor is that every instance of the class will be initialized
    //    to the same values and it is not possible to initialize each instance of the class with different values.
    
    //    The default constructor initializes: 
    //    All numeric fields in the class to zero.
    //    All string and object fields to null.



    // when there is no constructor created for the class, compiler will automatically creates default constructor  whenever the instace gets created


    class DefaultConstructors
    {
        public int Id;
        public string Name;

        public DefaultConstructors()
        {
            Id = 100;
            Name = "DefaultConstructors - Kamal  Ratnakar N";
        }
    }
}
