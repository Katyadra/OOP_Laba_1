using System;

namespace OOP1
{
    public class NumbManip
    {
        public int result;
        public int Summ(int a, int b)
        {
            result = a + b;
            return result;
        }
        public int Minus(int a, int b)
        {
            result = a - b;
            return result;
        }
        public int Multip(int a, int b)
        {
            result = a * b;
            return result;
        }
        public int Del(int a, int b)
        {
            result = a / b;
            return result;
        }
        public int Ostat(int a, int b)
        {
            result = a % b;
            return result;
        }
        public void Output()
        {
            Console.WriteLine($"Результат: {result}");
        }
    }

    internal class Numbers
    {
        static void Main(string[] args)
        {
            int a, b, r;
            char p;
            NumbManip res = new NumbManip();
            Console.WriteLine($"Введите первое число: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine($"Введите второе число: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Выберите желаемую операцию: ");
            p = char.Parse(Console.ReadLine());
            if (p == '+')
            {
                r = res.Summ(a, b);
                res.Output();
            }
            if (p == '-')
            {
                r = res.Minus(a, b);
                res.Output();
            }
            if (p == '*')
            {
                r = res.Multip(a, b);
                res.Output();
            }
            if (p == '/')
            {
                r = res.Del(a, b);
                res.Output();
            }
            if (p == '%')
            {
                r = res.Ostat(a, b);
                res.Output();
            }
        }
    }
}

