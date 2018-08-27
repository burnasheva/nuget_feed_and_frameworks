using System;
using Microsoft.Build.Framework;
using Microsoft.Build.Logging;
using Microsoft.Build.Utilities;

namespace PackageWithDotNetFrameworkDependencies
{
    public class Calculator
    {
        public static double plus(double a, double b)
        {
            return a + b;
        }

        public static void SomeMethodWithLogger()
        {
            string binLogFilePath = @"C:\temp\test.binlog";

            var binLogReader = new BinaryLogReplayEventSource();
            foreach (var record in binLogReader.ReadRecords(binLogFilePath))
            {
                var buildEventArgs = record.Args;

                // print command lines of all tool tasks such as Csc
                if (buildEventArgs is TaskCommandLineEventArgs taskCommandLine)
                {
                    Console.WriteLine(taskCommandLine.CommandLine);
                }
            }
        }
    }
}