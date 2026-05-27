using System;
using System.IO;

public class Repository
{
    string file = "records.txt";

    public void AddRecord(string data)
    {
        File.AppendAllText(file, data + "\n");
        Console.WriteLine("Record saved!");
    }

    public void ViewRecords()
    {
        if (File.Exists(file))
        {
            string data = File.ReadAllText(file);
            Console.WriteLine("\n--- RECORDS ---");
            Console.WriteLine(data);
        }
        else
        {
            Console.WriteLine("No records found.");
        }
    }
}