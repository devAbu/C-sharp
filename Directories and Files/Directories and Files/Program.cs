using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        // current directory
        string curDir = Directory.GetCurrentDirectory();
        Console.WriteLine(curDir);

        // create a new directory
        string dirOne = @"\textFiles";
        Directory.CreateDirectory(curDir + dirOne);

        // delete directory
        //Directory.Delete(curDir + dirOne);

        // check if exists 
        if(Directory.Exists(curDir + dirOne))
        {
            Console.WriteLine("Already Exists");
        }
        else
        {
            Directory.CreateDirectory(curDir + dirOne);
            Console.WriteLine("Created");
        }

        string[] directories = Directory.GetDirectories(curDir);

        // Console.WriteLine(string.Join("\n", directories));

        foreach (var item in directories)
        {
            Console.WriteLine(item);
        }

        string[] files = Directory.GetFiles(curDir);

        foreach (var item in files)
        {
            Console.WriteLine(item);
        }

        // easier way
        DirectoryInfo currentDirectory = new DirectoryInfo(Directory.GetCurrentDirectory() + @"\textFiles");

        if (currentDirectory.Exists)
        {
            Console.WriteLine("Already Exists");
        }
        else
        {
            currentDirectory.Create();
            Console.WriteLine("Created");
        }

        Console.WriteLine(currentDirectory.FullName);

        currentDirectory.CreateSubdirectory("subDirectory");

        DirectoryInfo[] directories2 = currentDirectory.GetDirectories();

        foreach (var item in directories2)
        {
            Console.WriteLine(item.FullName);
        }


        // FILES
        string fileName = "groceries.txt";

        Console.WriteLine(File.Exists(fileName));
        File.Create(fileName).Close();
        Console.WriteLine(File.Exists(fileName));

        FileInfo file = new FileInfo("drinks.txt");
        file.Create();

        Console.WriteLine(file.Name);
        Console.WriteLine(file.FullName);
        Console.WriteLine(file.Extension);
        Console.WriteLine(file.DirectoryName);

        DirectoryInfo pathToFile = file.Directory;

        Console.WriteLine(pathToFile.Name);

        FileInfo[] files2 = pathToFile.GetFiles();

        foreach (var item in files2)
        {
            Console.WriteLine(item.Name);
            Console.WriteLine(item.Exists);
        }

        // READ

        FileInfo drinksFile = new FileInfo("dummy.txt");

        string allText = File.ReadAllText(drinksFile.FullName);
        Console.WriteLine(allText);
        string[] allLines = File.ReadAllLines(drinksFile.FullName);
        Console.WriteLine(string.Join("\n", allLines));

        List<string> readLines = new List<string>();

        foreach (var item in File.ReadLines(drinksFile.FullName))
        {
            readLines.Add(item);
        }

        Console.WriteLine(string.Join("\n", readLines));

        // easier way
        string[] lines = File.ReadLines(drinksFile.FullName).ToArray();
        Console.WriteLine(string.Join("\n", lines));


        // WRITE
        string[] textToWrite =
        {
            "something",
            "juhu juhu juhu juhu",
            "Some text....some text....some text",
            "SomeText....someText....someText"
        };

        string fileNameToWrite = "writeTest.txt";

        FileInfo fileToWrite = new FileInfo(fileNameToWrite);

        if (fileToWrite.Exists)
        {
            fileToWrite.Delete();
            fileToWrite.Create().Close();
        }
        else
        {
            fileToWrite.Create().Close();
        }

        using (StreamWriter sw = fileToWrite.AppendText())
        {
            foreach (var item in textToWrite)
            {
                // sw.Write(item);
                sw.WriteLine(item);
            }
        }

        // read from file using stream reader
        using (StreamReader sr = fileToWrite.OpenText())
        {
            //Console.WriteLine(sr.ReadLine()); // first line
            //Console.WriteLine(sr.ReadLine()); // second line

            string line = string.Empty;

            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(sr.ReadLine());
            }
        }
    }
}
