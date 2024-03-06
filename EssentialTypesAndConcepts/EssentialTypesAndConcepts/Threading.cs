namespace EssentialTypesAndConcepts
{
    /// <summary>
    /// # Thread is a single sequence of instructions that a process can execute.
    /// 
    /// # When to use Single Threading and Multithreading ?
    ///    - Consider single threading when tasks need to be executed sequentially 
    ///      or when tasks are so straightforward that introducing multiple threads
    ///      unnecessarily complicates the code
    ///    
    ///    - Use multithreading when your application has tasks that can run concurrently,
    ///      independently, and without needing to be sequentially organized
    ///      
    /// # Task class, a higher-level way to work with multithreading.
    ///    - represents an asynchronous operation and is often easier and safer than directly
    ///      managing threads.
    ///    - tasks can also return a result and handle exceptions more smoothly.
    ///    
    /// # ThreadPool
    ///    - designed to make thread management more manageable by providing a 
    ///      pool of worker threads ready to be used
    ///    - more efficient because the execution threads are reused
    /// </summary>
    internal class Threading
    {
        // Single Threading example
        public void SingleThreading()
        {
            Thread thread = new Thread(new ThreadStart(Func1));
            thread.Start();
        }

        // Multithreading example
        public void MultipleThreading()
        {
            Thread thread1 = new Thread(new ThreadStart(Func1));
            Thread thread2 = new Thread(new ThreadStart(Func2));

            thread1.Start();
            thread2.Start();
        }
        public void Func1() => Thread.Sleep(1);
        public void Func2() => Thread.Sleep(2);

        // Multithreading with Async and Await
        public async Task MultiThreadingAsync()
        {
            await Task.Run(() => Func1());
            await Task.Run(() => Func2());

            Task<int> task = Task.Run(() =>
            {
                return 1+1;
            });

            int result = await task;
        }

        // ThreadPool
        public void ThreadPoolEx()
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(MyMethod));
        }

        public static void MyMethod(object obj)
        {
            Thread thread = Thread.CurrentThread;
            string message = $"Background: {thread.IsBackground}, Thread Pool: {thread.IsThreadPoolThread}, Thread ID: {thread.ManagedThreadId}";
            Console.WriteLine(message);
        }
    }
}
