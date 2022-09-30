using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Tumakov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 4.1");
            Console.Write("Введите число от 1 до 365 \t");
            int n = int.Parse(Console.ReadLine());
            DateTime dt = Convert.ToDateTime("01.01.2022");
            dt = dt.AddDays(n - 1);
            Console.WriteLine(dt.ToString("d MMMM"));
            Console.ReadKey();

            Console.WriteLine("Задание 4.2");
            Console.Write("Введите число от 1 до 365 \t");
            
            int n1 = int.Parse(Console.ReadLine());
            DateTime dt1 = Convert.ToDateTime("01.01.2022");
            if (n1>0 && n1 < 366)
            {
                dt1 = dt1.AddDays(n1 - 1);
                Console.WriteLine(dt1.ToString("d MMMM"));
            }
            else
            {
                Console.WriteLine("Вы ввели не то число");
            }
            Console.ReadKey();

            Console.WriteLine("Домашнее задание 4.1");
            Console.Write("Введите число от 1 до 365 \t");
            int n2 = int.Parse(Console.ReadLine());
            Console.Write("Введите год \t");
            int year = int.Parse(Console.ReadLine());
            DateTime dt2 = Convert.ToDateTime("01.01.2022");
            
            if (year%4==0 && year%100 !=0 || year % 400 == 0)
            {
                Console.Write("Год високосный: ");
            }
            else
            {
                Console.Write("Год невисокосный: ");
            }
            if (n2 > 0 || n2 < 366)
            {
                dt2 = dt2.AddDays(n2 - 1);
                Console.WriteLine(dt2.ToString("d MMMM"));
            }
            else
            {
                Console.WriteLine("Вы ввели не то число");
            }
            Console.ReadKey();



        }
    }
}
