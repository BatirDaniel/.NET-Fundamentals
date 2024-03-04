using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Xml.Linq;

namespace EssentialTypesAndConcepts
{
    /// <summary>
    /// Interfaces is a contract that : 
    ///  - Defines a set of members (methods , properties, events)
    ///  - Add interface in class or struct
    ///  - Class can implement many interfaces, but only one class
    ///  - Structure can't implement another structure, but many interfaces 
    /// </summary>
    
    public interface IInterface
    {
        public int MyProperty { get; set; }
        public void MyMethod();
    }

    public class Interface : IInterface, IComparable<Interface>, IEnumerable<Interface>, IFormattable
    {
        // Implementing my custom IInterface interface
        public int MyProperty { get; set; } = 7;

        public void MyMethod()
        {
            var item = new Interface();

            Console.WriteLine("Success !");

            // using ToString implementation
            Console.WriteLine(item.ToString("N", new CultureInfo("en-US")));
        }

        // Implementation of IComparable<Interfaces> interface, method will be called when
        // we will using Sort() method for Interfaces class 
        public int CompareTo(Interface other)
        {
            if (other is null) return 0;

            if (other.MyProperty < 10)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        // Implementation of IEnumerable<Interfaces> interface
        // allows simple and efficient iterations through custom collections

        private List<Interface> items = new List<Interface>();

        public IEnumerator<Interface> GetEnumerator()
        {
            foreach (var item in items)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        // Implementation of IFormattable interface

        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (String.IsNullOrEmpty(format)) format = "G";
            if (formatProvider == null) formatProvider = CultureInfo.CurrentCulture;

            switch (format.ToUpperInvariant())
            {
                case "G": //General format
                    return $"{MyProperty}";
                case "N": //Format with date and time
                    return $"{MyProperty} {DateTime.Now}";
                default:
                    throw new FormatException($"Format '{format}' is not suported.");
            }
        }
    }
}
