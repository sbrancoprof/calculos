﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplicação Cálculos");

            Console.Write($"4 + 2 = {Aritmetica.Somar(4, 2)}");
            Console.Write($"4 - 2 = {Aritmetica.Subtrair(4, 2)}");

            double t1 = Conversoes.ConverteTemperatura(Conversoes.ConversaoTemperatura.CelsiusFahrenheit, 36);
            double t1 = Conversoes.ConverteTemperatura(Conversoes.ConversaoTemperatura.FahrenheitCelsiust, 100);

            Console.WriteLine($"36º Celsius = {t1}º Farenheit");
            Console.WriteLine($"100º Farenheit = {t2}º Celsius");

            Console.ReadKey();
        }
    }
}
