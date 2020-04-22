using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            TestSet set = new TestSet();

            //var result = set.Where(i => i <=5).Aggregate(1, (acc, i) => acc * i);
            //var result = set.Aggregate(0, (acc, i) => acc + i);
            //var result = set.First(s => s % 2 == 0);
            //var resultSet = set.Where(s => s >100).Select(s => "*" + s.ToString() + "*");
            //foreach (string i in resultSet)
            //{
            //    Console.WriteLine(i);
            // }
            var resultSet = set.Select(i => new { Numder = i, IsEven = i % 2 == 0 }).OrderBy(r => r.IsEven);

            foreach (var element in resultSet)
            {
                Console.WriteLine(element.Numder);
            }
            //Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
