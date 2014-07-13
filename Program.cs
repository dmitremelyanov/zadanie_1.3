using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3
{
    class Program
    {
        static void Main(String[] args)
        {
            int i, m, j, n, k;
            Console.Write("Введите размер первого массива: ");
            m = int.Parse(Console.ReadLine());
            Console.Write("Введите размер второго массива: ");
            n = int.Parse(Console.ReadLine());
            Double[] a = new double[m];
            Double[] b = new double[n];
            Double[] c = new double[n + m];
            Console.WriteLine("Введите первый массив: ");
            for (i = 0; i < m; i++)
            {
                Console.Write("a[" + (i + 1) + "] = ");
                a[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Введите второй массив: ");
            for (i = 0; i < n; i++)
            {
                Console.Write("b[" + (i + 1) + "] = ");
                b[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.Write("Введите номер элемента начала вставки: ");
            k = int.Parse(Console.ReadLine());
            for (i = 0; i <= (k - 1); i++)
            {
                c[i] = a[i];
            }
            j = 0;
            for (i = (k); i < (k + n); i++)
            {
                c[i] = b[j];
                j++;
            }
            for (i = (k + n); i < (m + n); i++)
            {
                c[i] = a[k];
                k++;
            }
            for (i = 0; i < (m + n); i++)
                Console.WriteLine("c[" + (i + 1) + "] = " + c[i]);
            Console.ReadLine();

        }
    }
}
