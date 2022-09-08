using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a;
            Console.WriteLine("Напиши число");
            // проограмма выводит сообщение
            Console.Write("");
            // программа даёт возможность вводить пользователю 
            a = Byte.Parse(Console.ReadLine());
            // Байтим a английскую и консоль считывает
            int c; 
            // создаём прерименную c
            c = (a % 2 == 0)? a = 1: a & 1;
            // c английскую присваеваем a делится с остатком и ответ проверяется если ноль тогда программа прибавляет a присваевает 1 а если программа считывает и a = 1             // то программа ещё раз побитовое и 0 a
            Console.WriteLine(c);
            // в консоль выводим c
        }
    }
}
