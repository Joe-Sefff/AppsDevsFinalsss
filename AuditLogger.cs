using System;
using System.IO;

public class AuditLogger
{
    public void Log(string action)
    {
        File.AppendAllText("audit.txt", DateTime.Now + " - " + action + "\n");
    }
}