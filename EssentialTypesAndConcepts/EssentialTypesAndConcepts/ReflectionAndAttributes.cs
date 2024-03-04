using System.Reflection;

namespace EssentialTypesAndConcepts
{
    /// <summary>
    /// Reflection : 
    ///    - List types (classes , structs)
    ///    - Discover base or interface 
    ///    - List type members (methods, fields, properties)
    ///    - List method parameters (return, in, out)
    /// # Useful for building dynamically extensible applications
    /// 
    /// Attribute :
    ///    - Attributes can be attached to various types like classes, structs, enums, interfaces, delegates
    ///    
    /// </summary>
    
    public class ReflectionAndAttributes
    {
        public int MyProperty { get; set; }
        public void MyMethod()
        {
            Console.WriteLine("Hello from MyMethod!");
        }

        // using reflection
        public void UseReflection()
        {
            var obj = new ReflectionAndAttributes();
            Type type = obj.GetType();

            // Get all public properties of MyClass
            PropertyInfo[] properties = type.GetProperties();
            Console.WriteLine("Properties:");
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.Name);
            }

            // Get all public methods of MyClass
            MethodInfo[] methods = type.GetMethods();
            Console.WriteLine("\nMethods:");
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.Name);
            }
        }
    }

    /// <summary>
    ///  Decorate code with an attribute.
    /// </summary>

    [Serializable]
    public class Attribute
    {

    }
}
