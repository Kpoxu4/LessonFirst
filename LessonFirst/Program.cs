using System;
using System.Diagnostics.CodeAnalysis;
using static System.Collections.Specialized.BitVector32;

while (true)
{
    Console.Clear();
    Console.WriteLine("Калькулятор");
    string stringResult = Console.ReadLine();
    double result = 0;

    if (stringResult.Contains('.'))
        Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
    else
        Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("Ru");

    if (stringResult.Contains('/') || stringResult.Contains('*') || stringResult.Contains('-') || stringResult.Contains('+'))
    {
        var array = stringResult.Split('/', '-', '+', '*').ToArray();

        if (double.TryParse(array[0], out double x) && double.TryParse(array[1], out double y))
        {

            if (stringResult.Contains('/') && y != 0)
                result = x / y;

            if (stringResult.Contains('+'))
                result = x + y;

            if (stringResult.Contains('-'))
                result = x - y;

            if (stringResult.Contains('*'))
                result = x * y;

            Console.Clear();

            if (y == 0 && stringResult.Contains('/'))
                Console.WriteLine("На ноль делить нельзя");
            else
                Console.WriteLine($"{stringResult} = {Math.Round(result, 3, MidpointRounding.ToEven)}");
        }
        else
            Console.WriteLine("Ввели не корректные значения цифр");
    }
    else
        Console.WriteLine("Ввели не корректные значения арифметического действия");

    Console.WriteLine("для продолжение нажмите любую кнопку");
    Console.ReadLine();
}