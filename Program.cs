using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main()
    {
        Repository repo = new Repository();
        AuditLogger log = new AuditLogger();
        Validation val = new Validation();
        ReportGenerator report = new ReportGenerator();

        while (true)
        {
            Console.WriteLine("\n=== MENU ===");
            Console.WriteLine("1. Add Record");
            Console.WriteLine("2. View Records");
            Console.WriteLine("3. Generate Report");
            Console.WriteLine("4. Exit");
            Console.Write("Choice: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Enter data: ");
                string data = Console.ReadLine();

                if (val.IsValid(data))
                {
                    repo.AddRecord(data);
                    log.Log("Added record: " + data);
                }
                else
                {
                    log.Log("Invalid input");
                }
            }
            else if (choice == "2")
            {
                repo.ViewRecords();
                log.Log("Viewed records");
            }
            else if (choice == "3")
            {
                report.Generate();
                log.Log("Generated report");
            }
            else if (choice == "4")
            {
                break;
            }
        }
    }
}