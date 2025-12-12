using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Chapter3_4.LINQ
{
    internal class LINQDemo
    {
        // ✅ 1. LINQ with Collections
        static void LinqWithCollections()
        {
            Console.WriteLine("\n--- LINQ with Collections ---");

            var people = new List<Person>
            {
                new Person { Name = "Ram", Age = 25 },
                new Person { Name = "Sita", Age = 30 },
                new Person { Name = "Hari", Age = 22 }
            };

            var adults = people
                .Where(p => p.Age >= 25)
                .OrderBy(p => p.Name);

            foreach (var p in adults)
                Console.WriteLine($"{p.Name} - {p.Age}");
        }

        // ✅ 2. LINQ with XML
        static void LinqWithXml()
        {
            Console.WriteLine("\n--- LINQ with XML ---");

            var doc = XDocument.Load("LINQ\\employees.xml");

            var highEarners =
                from emp in doc.Descendants("Employee")
                where (int)emp.Attribute("Salary") > 50000
                select new
                {
                    Name = (string)emp.Attribute("Name"),
                    Salary = (int)emp.Attribute("Salary")
                };

            foreach (var e in highEarners)
                Console.WriteLine($"{e.Name} - {e.Salary}");
        }



        // ✅ 3. LINQ with DataTable
        static void LinqWithDataTable()
        {
            Console.WriteLine("\n--- LINQ with DataTable ---");

            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Age", typeof(int));

            dt.Rows.Add("Ram", 25);
            dt.Rows.Add("Sita", 30);
            dt.Rows.Add("Hari", 22);

            var result = dt.AsEnumerable()
                .Where(row => row.Field<int>("Age") > 23)
                .Select(row => new
                {
                    Name = row.Field<string>("Name"),
                    Age = row.Field<int>("Age")
                });

            foreach (var r in result)
                Console.WriteLine($"{r.Name} - {r.Age}");
        }


        static void LinqWithFiles()
        {
            Console.WriteLine("\n--- LINQ with Files (CSV) ---");

            var records = File.ReadAllLines("LINQ\\data.csv")
                .Skip(1)
                .Select(line => line.Split(','))
                .Select(parts => new
                {
                    Name = parts[0],
                    Age = int.Parse(parts[1])
                });

            foreach (var r in records)
                Console.WriteLine($"{r.Name} - {r.Age}");
        }

        public static void RunAllDemos()
        {
            LinqWithCollections();
            LinqWithXml();
            LinqWithDataTable();
            LinqWithFiles();
        }

    }
}
