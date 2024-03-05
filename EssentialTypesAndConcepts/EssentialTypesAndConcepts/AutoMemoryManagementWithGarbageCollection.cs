namespace EssentialTypesAndConcepts
{
    /// <summary>
    /// What does it means to have managed memory ?
    ///   # That the code execution is managed by the CLR (Common Language Runtime)
    ///   # You do not have to write code to allocate memory
    ///   
    /// Problems with old model : 
    ///    - Memory leak: from not removing pobject from memory
    ///    - Memory corruption: reading from wrong memory location
    ///    - Memory corruption: writing from wrong memory location
    ///    - Security vulnerabilities: buffer overflows
    ///    
    /// Heap is one contiguous memory area.
    /// The generations are logical constructs managed by the CLR.
    ///    
    /// The managed heap of GC is divided into three sections called generations:
    ///    # Gen 0 (Small)
    ///    # Gen 1 (Medium)
    ///    # Gen 2 (Large)
    ///    
    /// Why we have three generations ? 
    ///    - Collecting and compacting a portion of the heap is faster 
    ///    - New objects tend to have short lifetimes
    ///    - Older objects have longer lifetimes
    ///    
    /// How works ? 
    ///   # Gen 0  is full 
    ///      -> GC starts (All the reachable objects are moved from Gen 0 to Gen 1) 
    ///         --> Gen 0 is reset
    ///         
    ///   # Gen 1 is not checked until it gets full
    ///      -> GC starts (All the reachable objects are moved from Gen 1 to Gen 2)
    ///         --> Gen 1 is reset
    ///   
    ///   # Gen 2 objects are likely the longest living objects in the application
    ///      -> Perhaps they are objects used continuously and are needed as long 
    ///         as the application is running , there's no need to check it all the time.
    ///         --> GC will compact Gen 2 when it deems it necessary
    ///         
    /// </summary>
    internal class AutoMemoryManagementWithGarbageCollection
    {
        public void GCDemonstration()
        {
            // Gen 0 filling up
            for (int i = 0; i < 10000; i++)
            {
                // Allocation of memory to fill Gen 0
                var obj = new object();
            }
            // Gen 0 could be full and GC could start, moving accessible objects to Gen 1 and resetting Gen 0

            Console.WriteLine("Gen 0 has been filled and potentially collected.");
            ShowGCGenInfo();

            // Gen 1 filling up
            for (int i = 0; i < 10000; i++)
            {
                // We force a Gen 0 collection to move objects to Gen 1
                GC.Collect(0);
            }
            // Gen 1 could be full and GC could start, moving accessible objects to Gen 2 and resetting Gen 1

            Console.WriteLine("Gen 1 has been filled and potentially collected.");
            ShowGCGenInfo();

            // Gen 2 is collected less often, as it contains objects that survived previous collections
            // indicating that they are likely needed throughout the application

            // Gen 2 collection for demonstration
            GC.Collect(2);
            Console.WriteLine("Gen 2 has been collected.");
            ShowGCGenInfo();
        }

        static void ShowGCGenInfo()
        {
            Console.WriteLine($"Generation 0: {GC.CollectionCount(0)}");
            Console.WriteLine($"Generation 1: {GC.CollectionCount(1)}");
            Console.WriteLine($"Generation 2: {GC.CollectionCount(2)}");
        }
    }
}
