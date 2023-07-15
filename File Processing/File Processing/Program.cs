using System;
using System.IO;

class FileProcessor
{
    public void ProcessFile(string filePath)
    {
        try
        {
            using (FileStream file = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite))
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    string fileContent = sr.ReadToEnd();
                    Console.WriteLine("File processing completed successfully.");
                }
            }
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine($"Error: File '{filePath}' not found. Please check the file path and try again.");
        }
        catch (InvalidDataException ex)
        {
            Console.WriteLine($"Error: Invalid file format. File '{filePath}' does not contain valid data.");
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine($"Error: Insufficient file permissions. Access to file '{filePath}' is denied.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while processing the file: {ex.Message}");
        }
    }
}

class Program
{
    static void Main()
    {
        FileProcessor fileProcessor = new FileProcessor();
        string filePath = @"C:\Users\Vamsi Ayiluri\Documents\calender,age,numerics query.txt";

        fileProcessor.ProcessFile(filePath);

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
