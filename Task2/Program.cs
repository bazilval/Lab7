using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Создать метод для вычисления объема и площади поверхности куба по длине его ребра.*/
namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = IntInput("Введите сторону куба: ");
            int v, s;
            CalcCubeVolume(a, out s, out v);
            PrintLine($"\nПлощадь поверхности куба = {s}.\nОбъем куба = {v}.");
            PressToExit();
        }

        static void CalcCubeVolume(int a, out int s, out int v)
        {
            s = a * a * 6;
            v = a * a * a;
        }

        static int IntInput()
        {
            return Int32.Parse(Console.ReadLine());
        }
        static int IntInput(string text)
        {
            Console.Write(text);
            return Int32.Parse(Console.ReadLine());
        }
        static void PrintLine(string str)
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
