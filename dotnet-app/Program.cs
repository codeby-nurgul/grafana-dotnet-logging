using System.Threading;
using System;
using System.IO;

var logDir = "/app/logs";
Directory.CreateDirectory(logDir);
var logFile = Path.Combine(logDir, "app.log");

for (int i = 0; i < 100; i++)
{
    File.AppendAllText(logFile, $"{DateTime.Now:O} - INFO - Log entry {i}\n");
    Thread.Sleep(500);
}

