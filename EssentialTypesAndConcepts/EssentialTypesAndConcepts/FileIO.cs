namespace EssentialTypesAndConcepts
{
    /// <summary>
    /// # System.IO namespace has various classes that are used for performing
    ///   numerous operations with files, such as creating and deleting files,
    ///   reading from or writing to a file, closing a file :
    ///   
    ///     - BinaryReader => Reads primitive data from a binary stream.
    ///     
    ///     - BinaryWriter => Writes primitive data in binary format.
    ///     
    ///     - BufferedStream => A temporary storage for a stream of bytes.
    ///     
    ///     - Directory => Helps in manipulating a directory structure.
    ///     
    ///     - DirectoryInfo => Used for performing operations on directories.
    ///     
    ///     - DriveInfo => Provides information for the drives.
    ///     
    ///     - File => Helps in manipulating files.
    ///     
    ///     - FileInfo => Used for performing operations on files.
    ///     
    ///     - FileStream => Used to read from and write to any location in a file.
    ///     
    ///     - MemoryStream => Used for random access to streamed data stored in memory.
    ///     
    ///     - Path => Performs operations on path information.
    ///     
    ///     - StreamReader => Used for reading characters from a byte stream.
    ///     
    ///     - StreamWriter => Is used for writing characters to a stream.
    ///     
    ///     - StringReader => Is used for reading from a string buffer.
    ///     
    ///     - StringWriter => Is used for writing into a string buffer.
    /// 
    /// 
    /// # FileMode enumerator defines various methods for opening files : 
    /// 
    ///     - Append − It opens an existing file and puts cursor at the end of file, 
    ///       or creates the file, if the file does not exist.
    ///       
    ///     - Create − It creates a new file.
    ///     
    ///     - CreateNew − It specifies to the operating system, that it should create a new file.
    ///     
    ///     - Open − It opens an existing file.
    ///     
    ///     - OpenOrCreate − It specifies to the operating system that it should open a file 
    ///       if it exists, otherwise it should create a new file.
    ///       
    ///     - Truncate − It opens an existing file and truncates its size to zero bytes.
    ///    
    /// 
    /// # FileAccess enumerators have members: 
    ///     - Read
    ///     - ReadWrite
    ///     - Write
    ///    
    /// 
    /// # FileShare enumerators have the following members :
    ///     - Inheritable − It allows a file handle to pass inheritance to the child processes
    ///     - None − It declines sharing of the current file
    ///     - Read − It allows opening the file for readin.
    ///     - ReadWrite − It allows opening the file for reading and writing
    ///     - Write − It allows opening the file for writing
    /// </summary>
    internal class FileIO
    {
        public void FileDemonstration()
        {
            // The File class provides us built-in methods that allow us to perform
            // input/output operations on files :
            //
            //    - Create() -> Create or overwrite a file in the specified path.
            //
            //    - Open() -> Opens a FileStream on the specified path with read / write access
            //
            //    - WriteAllText() -> Create a new file, writes the specified string to the file, and then closes the file
            //
            //    - ReadAllText() -> Opens a text file, reads all lines of the file, and then closes the file.
            //
            //    - Copy() -> Copies an existing file to a new file.Overwriting a file of the same name is not allowed.
            //
            //    - AppendAllText() -> Opens a file, appends the specified string to the file, and then closes the
            //                         file. If the file does not exist, this method creates a file, writes the specified
            //                         string to the file, then closes the file.

            // Create a file
            var pathName = @"";
            FileStream fsCreate = File.Create(pathName);

            // Open an existing file
            FileStream fsOpen = File.Open(pathName, FileMode.Open);

            // Write to a file
            var text = "Hello guys !";
            File.WriteAllText(pathName, text);

            // Read a file
            string readText = File.ReadAllText(pathName);

            // Copy a file
            string sourceFilePath = @"";
            string destFilePath = @"";

            File.Copy(sourceFilePath, destFilePath, true);

            // Adding extra texts to a file
            string appendText = ".NET Fundamentals";
            File.AppendAllText(pathName, appendText);
        }
    }
}
