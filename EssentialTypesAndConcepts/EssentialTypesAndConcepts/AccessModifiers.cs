namespace EssentialTypesAndConcepts
{
    /// <summary>
    /// # Access modifiers specify the accessibility of an object and all of its members, 
    ///   they help enforce encapsulation by limiting the scope of members and protecting 
    ///   them from unintended access or modification
    ///   
    /// # Four types of access modifiers:
    ///    - Private -> members declared with the private access modifier are only 
    ///                 accessible within the class in which they are declared.
    ///                 
    ///    - Public -> members declared with the public access modifier are accessible
    ///                from anywhere in the code, including derived classes.
    ///                
    ///    - Protected -> the object is accessible inside the class and in all classes
    ///                   that derive from that class
    ///                   
    ///    - Internal -> the object is accessible only inside its own assembly but not
    ///                  in other assemblies
    ///                  
    ///    - Protected Internal -> we can access the protected internal member only in
    ///                            the same assembly or in a derived class in other assemblies
    ///                  
    ///    - Private Protected -> we can access members inside the containing class or 
    ///                           in a class that derives from a containing class, but
    ///                           only in the same assembly
    ///    
    /// # By using the right access modifier, we ensure that our code is secure, easy to use, and maintain.
    /// </summary>
    public class Calculator
    {
        public int Value { get; set; }
        public int IncrementValue(int value)
        {
            return value + 1;
        }
    }

    public class Shape
    {
        protected int Width { get; set; }
        protected int Height { get; set; }
        public virtual int GetArea()
        {
            return Width * Height;
        }
    }

    internal class Logger
    {
        internal string LogInternalMessage(string message)
        {
            return $"Logged at {DateTime.Now}, Message: {message}";
        }

        protected internal string LogInternalProtectedMessage(string message)
        {
            return $"Logged at {DateTime.Now}, Message: {message}";
        }
    }

    public class Employee
    {
        private protected int EmployeeId { get; set; }
        private protected string Name { get; set; }
        private protected double Salary { get; set; }

        public virtual string GetEmployeeDetails()
        {
            return $"Employee ID: {EmployeeId}, Name: {Name}, Salary: {Salary}";
        }
    }

    public class MainClass : Shape
    {
        public MainClass(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public void ExamplesAccessMidifiers()
        {
            // the public access modifier makes it possible to create classes with well-defined public interfaces,
            // that we can easily use and test from the other parts of the code
            var calculator = new Calculator();
            calculator.Value = 15;

            var result = calculator.IncrementValue(calculator.Value);
            Console.WriteLine(result);

            // we use the protected access modifier in C# for creating specialized derived classes that can access
            // members of a base class.
            var rectangle = new MainClass(10, 5);

            var area = rectangle.GetArea();
            Console.WriteLine(area);

            // the internal access modifier makes it possible to create classes that are useful within the same
            // assembly but are not part of the public API
            var logger = new Logger();

            var messageLog = logger.LogInternalMessage("This is a message");
            Console.WriteLine(messageLog);
        }
    }

    class DerivedLogger : Logger
    {
        // by using the protected internal access modifier, we can expose members that are needed for customization
        // and derivation, but not for direct use by external code
        public string LogMessageFromDerivedClass(string message)
        {
            return $"Derived Log: {LogInternalProtectedMessage(message)}";
        }
    }

    // need to be created in another assembly
    public class ExternalManager : Employee
    {
        // by using private protected access modifier, we can restrict access to certain members of our base
        // classes to only the derived classes within the same assembly, while still allowing those derived classes
        // to inherit and extend the functionality of the base classes
        public override string GetEmployeeDetails()
        {
            EmployeeId = 3;
            Name = "David";
            Salary = 80000;
            return $"ExternalManager Details: {base.GetEmployeeDetails()}";
        }
    }
}
