using System;
using System.Linq;

namespace KISS_Principle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar precios de los platos
            Console.Write("Ingrese los precios de los platos (separados por comas): ");
            string input = Console.ReadLine();

            // Convertir la entrada en un array de decimales
            decimal[] prices = input.Split(',').Select(decimal.Parse).ToArray();

            // Preguntar por la propina
            Console.Write("¿Desea agregar una propina personalizada? (s/n): ");
            bool customTip = Console.ReadLine().ToLower() == "s";

            decimal tipPercentage = 0.10m; // Propina predeterminada del 10%
            if (customTip)
            {
                Console.Write("Ingrese el porcentaje de propina (por ejemplo, 15 para 15%): ");
                tipPercentage = decimal.Parse(Console.ReadLine()) / 100;
            }

            // Calcular el total
            decimal total = CalculateTotal(prices, tipPercentage);

            // Mostrar el resultado
            Console.WriteLine($"Total a pagar (con propina del {tipPercentage * 100}%): {total}");
        }

        static decimal CalculateTotal(decimal[] prices, decimal tipPercentage)
        {
            // Sumar los precios de los platos
            decimal subtotal = prices.Sum();

            // Calcular la propina
            decimal tip = subtotal * tipPercentage;

            // Retornar el total
            return subtotal + tip;
        }
    }
}