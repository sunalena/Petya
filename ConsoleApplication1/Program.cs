using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        public bool funkch(int a, int b, int c)
        {
            if(a == 0)
            {
                throw new ArgumentException();
            }
            if (b * b - 4 * a * c >= 0)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            
        }
    }
}
