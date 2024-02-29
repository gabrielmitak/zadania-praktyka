using System;
using System.IO;

class Program
{
    static void Main()
    {
       
        string filePath = @"C:/test/test_gab_mit.txt";

        try
        {
            
            string fileContent = File.ReadAllText(filePath);

          
            Console.WriteLine("Zawartość pliku:");
            Console.WriteLine(fileContent);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Nie można odnaleźć pliku.");
        }
        catch (IOException)
        {
            Console.WriteLine("Wystąpił błąd podczas odczytu pliku.");
        }

        Console.ReadLine();
    }
}
