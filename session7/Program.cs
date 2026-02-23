using System.Runtime.Intrinsics.X86;
using System.Threading.Channels;

namespace session7
{
    #region question1
    //class Personclass
    //{
    //     public string name;
    //}
    //struct Personstruct
    //{
    //    public string name;
    //}
    #endregion
    #region question2
    //class MyClass
    //{ 
    //    public string name;
    //    private int age;
    //    public MyClass(string name, int age)
    //    {
    //        this.name = name;
    //        this.age = age;
    //    }

    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
        #region question1
        //Personclass p1 = new Personclass();
        //p1.name = "Alice";
        //Personclass p2 = p1;
        //p2.name = "Bob";
        //Console.WriteLine(p1.name); // Output: Bob
        //Personstruct s1 = new Personstruct();
        //s1.name = "Charlie";
        //Personstruct s2 = s1;
        //s2.name = "Dave";
        //Console.WriteLine(s1.name); // Output: Charlie
        //class? Reference type, stored on the heap, accessed via reference, can be null, supports inheritance and polymorphism.
        //struct? Value type, stored on the stack, accessed directly, cannot be null (unless nullable), does not support inheritance or polymorphism.
        #endregion
        #region question2
        //MyClass obj1 = new MyClass("Alice", 30);
        //MyClass obj2 = obj1;
        //obj2.name = "Bob";
        ////obj2.age = 40; // Error: 'MyClass.age' is inaccessible due to its protection level
        //Console.WriteLine(obj1.name); // Output: Bob
        // private=> accessible only within the class
        // public=> accessible from anywhere
        #endregion
        #region question3
        //Describe the steps to create and use a class library in Visual Studio?
        //1. Create a new Class Library project in Visual Studio.
        //2. Add your class files and implement the desired functionality.
        //3. Build the project to generate the DLL file.
        //4. In your main application project, add a reference to the class library DLL.
        //5. Import the namespace of the class library in your main application code.
        //6. Create instances of the classes from the library and use their methods as needed.
        #endregion
        #region question4
        //What is a class library? Why do we use class libraries ?
        //A class library is a collection of pre-written classes, methods, and other code that can be reused across multiple projects. We use class libraries to promote code reuse, improve maintainability, and reduce development time by leveraging existing functionality instead of writing code from scratch.

        #endregion
    
    }

}
}
}
