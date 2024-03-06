namespace EssentialTypesAndConcepts
{
    /// <summary>
    /// # Classes are fundamental parts of object-oriented programming language.
    /// 
    /// # Types of classes:
    ///    - Abstract
    ///        # abstract class is a class that provides the definition for its subclasses.
    ///        # an abstract class can not be instantiated. An abstract class is used to provide
    ///          a base for child classes to extend and implement abstract methods and override
    ///          or use the implemented methods in the abstract class
    ///            
    ///    - Partial 
    ///        # partial class is used to divide properties, methods, and events into multiple 
    ///         partial classes that are joined in a single class at compile time
    ///        # partial class is useful when the class definition is too large or you are
    ///         working on a complex model or feature and you want to divide the responsibility
    ///         of implementation into more than one developer
    ///         
    ///    - Sealed 
    ///       # sealed class is a class that can not be inherited
    ///       # sealed classes are used to prevent inheritance from other classes
    ///       
    ///    - Static 
    ///       # static classes are the classes that can not be instantiated, this means you 
    ///         can create an object (instance) of a static type class using the new keyword
    ///       # you can directly call static class members using their names
    /// </summary>  

    abstract class AbstractClass
    {
        // your code
    }

    partial class PartialClass
    {
        // your code
    }

    sealed class SealedClass
    {
        // your code
    }

    static class StaticClass
    {
        // your code
    }
}
