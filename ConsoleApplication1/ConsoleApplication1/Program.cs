using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            DbContext foo = new DbContext("foo");
            Console.WriteLine(foo.Database.Connection.ConnectionString);
        }
    }
}
