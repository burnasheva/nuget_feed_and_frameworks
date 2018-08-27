using System;
using Microsoft.Build.Framework;
using Microsoft.Build.Logging.StructuredLogger;

namespace PackageWithNetCoreAppDependencies
{
    class Program
    {
        public static double plus(double a, double b)
        {
            return a + b;
        }

        public static void SomeMethodWithLogger()
        {
            
        }
    }
}