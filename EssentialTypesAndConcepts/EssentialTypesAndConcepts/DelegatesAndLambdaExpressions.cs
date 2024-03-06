namespace EssentialTypesAndConcepts
{
    /// <summary>
    /// # Delegates represents a method signature :
    ///   - Action delegates => method that returns void
    ///   - Func dalegates => method that has a return type
    ///   
    /// # Delegates are a .NET concept, lambda expressions are a programing language concept.
    /// </summary>
    public class DelegatesAndLambdaExpressions
    {
        public void Show()
        {
            Func<int, int, bool> theDel;
            theDel = new Func<int, int, bool>(AreBothEven);

            // use C# lambda expression to inline code
            theDel = new Func<int, int, bool>
                ((first, second) => first % 2 == 0 && second % 2 == 0);

            Console.WriteLine(theDel.Invoke(6, 7));
            Console.WriteLine(theDel(6, 7));
        }

        public bool AreBothEven(int first, int second)
        {
            return first % 2 == 0 && second % 2 == 0;
        }
    }
}
