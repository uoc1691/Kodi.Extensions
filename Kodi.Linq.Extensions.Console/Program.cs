using MiniProfiler.Windows;
using StackExchange.Profiling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kodi.Linq.Extensions;

namespace Kodi.Linq.Extensions.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = null;

            ConsoleProfiling.Start();

            System.Console.WriteLine("Starting to call methods..");

            using (StackExchange.Profiling.MiniProfiler.Current.Step("Create List of Objects"))
            {
                list = new List<Employee>();

                for (int i = 0; i < 4000; i++)
                {
                    list.Add(new Employee
                    {
                        Id = i,
                        FirstName = string.Concat("FN ", i),
                        LastName = string.Concat("LN ", i),
                    });
                }
            }

            System.Console.WriteLine("We are going to shuffle a list of " + list.Count + " items");

            using (StackExchange.Profiling.MiniProfiler.Current.Step("Shuffle items"))
            {
                var shuffledList = list.Shuffle();
            }

            //Stop profiling and show results
            System.Console.WriteLine(ConsoleProfiling.StopAndGetConsoleFriendlyOutputStringWithSqlTimings());

            //Allow viewing of results
            System.Console.WriteLine("... press 'Enter' to exit process ...");
            System.Console.ReadLine();
        }
    }
}
