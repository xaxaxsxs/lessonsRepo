using System;
class ConsoleApp7
{
    static void Main()
    {
        double n1, n2;
        n1 = 10;
        n2 = 20;

        double answ = 0;

        answ = n1 - n2;

        Console.WriteLine(answ + " Разность ");

        answ = n1 + n2;

        Console.WriteLine(answ + " Сумма");

        answ = n1 * n2;

        Console.WriteLine(answ + " Произведение");

        answ = n1 / n2;

        Console.WriteLine(answ + " Частное");

        Console.WriteLine("числа: " + n1 + "  и  " + n2);
    }
}