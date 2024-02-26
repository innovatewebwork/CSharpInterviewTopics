namespace CSharpInterview
{
    // sealed keyword - will stops inheritance and will allow object creation
    // in this case even though the Singleton class  has sealed key word, it will not create instance of sealed class because of the private constructor
    //  
    public sealed class Singleton
    {
        private static Singleton instance = null;
        private static object _lock = new object();

        private Singleton() { }// Private Constructor will now allow object instantiation and inheritance

        public static Singleton GetInstnace(string value)
        {
            if(instance == null)
            {
                lock (_lock)
                {
                    if(instance == null)
                    {
                        instance = new Singleton();
                        instance.Value = value;
                    }
                }
            }
            return instance;
        }
        public string Value { get; set; }
    }
}
