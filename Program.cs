using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOneDirArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //константный массив
            int[] mas = { 5, 8, 1, 9, 78 };
            foreach (var item in mas)
            {
                Console.WriteLine(item);
            }
        }
    }
}
