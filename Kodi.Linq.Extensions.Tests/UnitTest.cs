using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;

namespace Kodi.Linq.Extensions.Tests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestShuffleFisherYatesUsingStringArray()
        {
            var list = new List<string>()
            {
                "Sri Lanka", "Australia", "United States", "Egypt", "Finland", "Germany", "Hungary"
            };

            var shuffledList = list.Shuffle();

            foreach (var item in shuffledList)
            {
                Trace.WriteLine(item);
            }
        }

        [TestMethod]
        public void TestShuffleFisherYatesUsingObjectArray()
        {
            var list = new List<Employee>()
            {
                new Employee { Id = 1, FirstName = "James", LastName = "Dean" },
                new Employee { Id = 2, FirstName = "Jack", LastName = "Reacher" },
                new Employee { Id = 3, FirstName = "Ethan", LastName = "Hunt" },
                new Employee { Id = 4, FirstName = "Steve", LastName = "Randle" },
                new Employee { Id = 5, FirstName = "Ray", LastName = "Ferrier" },
                new Employee { Id = 6, FirstName = "David", LastName = "Adams" },
                new Employee { Id = 7, FirstName = "Pete", LastName = "Mitchel" },
                new Employee { Id = 8, FirstName = "Nathan", LastName = "Algren" }
            };

            var shuffledList = list.Shuffle();

            foreach (var item in shuffledList)
            {
                Trace.WriteLine(item.Id + " " + item.FirstName + " " + item.LastName);
            }
        }        
    }

    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
