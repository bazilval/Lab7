using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Обязательная задача*. Два треугольника заданы длинами своих сторон. 
 * Определить, площадь какого из них больше (создать метод для вычисления 
 * площади  треугольника по длинам его сторон).  
 * Для решения задачи можно использовать формулу Герона */
namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintLine("Введите стороны первого треугольника:");
            int a1 = IntInput();
            int b1 = IntInput();
            int c1 = IntInput();
            double s1 = CalcSquare(a1, b1, c1);
            PrintLine($"Площадь первого треугольника = {s1}.");
            PrintLine("\nВведите стороны второго треугольника:");
            int a2 = IntInput();
            int b2 = IntInput();
            int c2 = IntInput();
            double s2 = CalcSquare(a2, b2, c2);
            PrintLine($"Площадь второго треугольника = {s2}.");
            string result = (s1 > s2) ? "Площадь первого больше." : (s1 < s2)?"Площадь второго больше.": (s1!=0 && s1==s2)?"Треугольники равны.":"Один треугольник или оба не существуют.";
            PrintLine($"\nРезультат: {result}");

            PressToExit();

        }
        static double CalcSquare(int a, int b, int c)
        {
            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return s;
        }
        static int IntInput()
        {
            return Int32.Parse(Console.ReadLine());
        }
        static void PrintLine(string str)
        {
            Console.WriteLine(str);
        }
        static void PrintLine(int str)
        {
            Console.WriteLine(str);
        }
        static void PrintLine(double str)
        {
            Console.WriteLine(str);
        }
        static void PressToExit()
        {
            PrintLine("\nНажмите любую клавишу для выхода.");
            Console.ReadKey();
        }
    }
}
