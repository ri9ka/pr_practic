using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_practic
{
    class Program
    {
        static void Main()
        {
            double x, y;
            string color;

            Console.WriteLine("Точка");
            Console.Write("Введите координату х -> ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координатуy -> ");
            y = Convert.ToDouble(Console.ReadLine());
            tochka tochkaFirst = new tochka(x, y);
            Console.WriteLine(tochkaFirst);
            tochka tochkaSecond = new tochka(4, 6);
            tochka tochkaAddition = tochkaFirst + tochkaSecond;
            Console.WriteLine("Сложение двух точек " + tochkaAddition);

            Console.WriteLine("Цветная точка");
            Console.Write("Введите координату х -> ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату y -> ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите цвет точки -> ");
            color = Console.ReadLine();
            ColoredTochka ctFirst = new ColoredTochka(color, x, y);
            Console.WriteLine(ctFirst);

            Console.WriteLine("Линяя");
            double x2, y2;
            Console.WriteLine("первая позиция");
            Console.Write("Введите х -> ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y -> ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("вторая позиция");
            Console.Write("Введите координату х -> ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату y -> ");
            y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nСравнение\n");
            tochka tochkaFirst_Line = new tochka(x, y);
            tochka tochkaSecond_Line = new tochka(x2, y2);
            Line lineFirst = new Line(tochkaFirst_Line, tochkaSecond_Line);
            Line lineSecond = new Line(tochkaFirst_Line, tochkaSecond_Line);
            Console.Write(lineFirst);
            Console.WriteLine(lineSecond);
            Console.WriteLine(lineFirst == lineSecond);

            Console.WriteLine("\nЦветная линия");
            Console.WriteLine("первая позиция");
            Console.Write("Введите х -> ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y -> ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("вторая позиция");
            Console.Write("Введите координату х -> ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату y -> ");
            y2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите цвет линии -> ");
            color = Console.ReadLine();
            tochka tochkaFirst_ColoredLine = new tochka(x, y);
            tochka tochkaSecond_ColoredLine = new tochka(x2, y2);
            ColoredLine coloredlineFirst = new ColoredLine(tochkaFirst_ColoredLine, tochkaSecond_ColoredLine, color);
            Console.WriteLine(coloredlineFirst);

            Console.WriteLine("Многоугольник");
            Loap polygonFirst = new Loap(lineFirst, lineSecond, new Line(tochkaFirst, tochkaSecond));
            Console.WriteLine(polygonFirst);
            Console.ReadLine(); 
        }
    }
}