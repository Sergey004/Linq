using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class TestSet : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        { 
            for (int i =1; i <=100;i++)
            {
                Console.WriteLine("Обращение к элементу: {0}", i);
                yield return i;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
        
}
