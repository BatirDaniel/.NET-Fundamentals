namespace EssentialTypesAndConcepts
{
    /// <summary>
    /// Hundreds of exception classes available or create a custom one.
    /// 
    /// # Exception pipeline
    ///    - Library throws an exception when a file is not found ...
    ///    - The .NET runtime manages the exception process
    ///    - Application handles the exceptions
    ///    
    /// # Handle a exception properly :
    ///    - Exception thrower
    ///    - Exception catcher
    ///    
    /// # Without the thrower , we dont't know anything is wrong.
    /// # Without  the catcher, the application crashes.
    /// </summary>
    public class HandlingExceptions
    {
        public void HandleExceptions()
        {
            try
            {
                // code that needs to be recover from any exceptions
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                // perform cleanup tasks, such as closing the file
            }
        }
    }
}
