using System;

namespace OOP1
{
    public class NumbManip // Класс для манипуляции с числами
    {
        public int result;
        public int Summ(int a, int b) // метод для суммы
        {
            result = a + b;
            return result;
        }
        public int Minus(int a, int b) // метод для вычитания
        {
            result = a - b;
            return result;
        }
        public int Multip(int a, int b) // метод для умножения
        {
            result = a * b;
            return result;
        }
        public int Del(int a, int b) // метод для целочисленного деления
        {
            result = a / b;
            return result;
        }
        public int Ostat(int a, int b) // метод для остатка
        {
            result = a % b;
            return result;
        }
        public void Output() // метод для вывода
        {
            Console.WriteLine($"Результат: {result}");
        }
    }

    internal class Numbers
    {
        static void Main(string[] args)
        {
            int a, b, r; // Переменные для чисел
            char p; // Переменная для операции
            NumbManip res = new NumbManip(); // создание нового объекта
            Console.WriteLine($"Введите первое число: ");
            a = int.Parse(Console.ReadLine()); // Ввод первого числа
            Console.WriteLine($"Введите второе число: ");
            b = int.Parse(Console.ReadLine()); // Ввод второго числа
            Console.WriteLine($"Выберите желаемую операцию: ");
            p = char.Parse(Console.ReadLine()); // Выбор операции
            if (p == '+') 
            {
                res.Summ(a, b); // Вызов метода
                res.Output(); // Вывод
            }
            if (p == '-')
            {
                res.Minus(a, b); // Вызов метода
                res.Output(); // Вывод
            }
            if (p == '*')
            {
                res.Multip(a, b); // Вызов метода
                res.Output(); // Вывод
            }
            if (p == '/')
            {
                res.Del(a, b); // Вызов метода
                res.Output(); // Вывод
            }
            if (p == '%')
            {
                res.Ostat(a, b); // Вызов метода
                res.Output(); // Вывод
            }
        }
    }
}