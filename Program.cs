using System;
using System.Collections.Generic;
using System.Data;
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

            Console.Write($"4 + 2 = {Aritmetica.Somar(4, 2)}\n");
            Console.Write($"4 - 2 = {Aritmetica.Subtrair(4, 2)}\n");

            double t1 = Conversoes.ConverteTemperatura(Conversoes.ConversaoTemperatura.CelsiusFahrenheit, 36);
            double t2 = Conversoes.ConverteTemperatura(Conversoes.ConversaoTemperatura.FahrenheitCelsius, 100);

            Console.WriteLine($"36º Celsius = {t1}º Farenheit");
            Console.WriteLine($"100º Farenheit = {t2}º Celsius");

            double d1 = Conversoes.ConverteDistancias(Conversoes.ConversaoDistancia.MetrosMilhas, 300);
            double d2 = Conversoes.ConverteDistancias(Conversoes.ConversaoDistancia.MilhasMetros, 1000);

            Console.WriteLine($"300 metros = {d1} milhas");
            Console.WriteLine($"1000 milhas = {d2} metros");

            Console.ReadKey();
        }
    }
}
