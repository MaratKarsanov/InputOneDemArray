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
            //ввод элементов массива в строку(сокращенно)
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[n];
            string[] tempMass = Console.ReadLine().Split();
            for (var i = 0; i < n; i++)
            {
                mas[i] = Convert.ToInt32(tempMass[i]);
            }

            foreach (var item in mas)
            {
                Console.WriteLine(item);
            }
        }
    }
}
