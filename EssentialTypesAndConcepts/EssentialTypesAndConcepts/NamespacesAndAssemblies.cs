using System.Reflection;
using System.Runtime.InteropServices;

/// <summary>
/// - Assemblies are physical boundaries for code .
/// - Namespaces are logical containers for code .
/// </summary>

namespace EssentialTypesAndConcepts
{
    public class CheckIfAFileIsInAssembly
    {
        public void Check()
        {
            try
            {
                string path = Path.Combine(
                    RuntimeEnvironment.GetRuntimeDirectory(),
                    "System.Net.dll");

                AssemblyName testAssembly = AssemblyName.GetAssemblyName(path);
                Console.WriteLine("Yes, the file is an assembly.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file cannot be found.");
            }
            catch (BadImageFormatException)
            {
                Console.WriteLine("The file is not an assembly.");
            }
            catch (FileLoadException)
            {
                Console.WriteLine("The assembly has already been loaded.");
            }
        }
    }
    public class NamespacesAndAssemblies
    {
        public int MyProperty = 8;
    }
}

namespace EssentialTypesAndConcepts_Copy
{
    public class NamespacesAndAssemblies_Copy
    {
        public int MyProperty_Copy { get; set; }


        public NamespacesAndAssemblies_Copy()
        {
            var namespacesAndAssemblies = new EssentialTypesAndConcepts.NamespacesAndAssemblies();

            // Get value of MyPropery from another assembly
            MyProperty_Copy = namespacesAndAssemblies.MyProperty;
        }
    }
}
