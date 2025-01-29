using System;

namespace DRY_Principle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar el tipo de empleado
            Console.Write("Seleccione el tipo de empleado (1: Tiempo completo, 2: Medio tiempo): ");
            int employeeType = int.Parse(Console.ReadLine());

            decimal salary = 0;

            if (employeeType == 1)
            {
                // Empleado de tiempo completo
                Console.Write("Ingrese el salario base: ");
                decimal baseSalary = decimal.Parse(Console.ReadLine());
                salary = CalculateNetSalary(baseSalary);
            }
            else if (employeeType == 2)
            {
                // Empleado de medio tiempo
                Console.Write("Ingrese el sueldo por hora: ");
                decimal hourlyRate = decimal.Parse(Console.ReadLine());
                Console.Write("Ingrese las horas trabajadas: ");
                int hoursWorked = int.Parse(Console.ReadLine());
                salary = CalculateNetSalary(hourlyRate * hoursWorked);
            }
            else
            {
                Console.WriteLine("Tipo de empleado no válido.");
                return;
            }

            // Mostrar el salario neto
            Console.WriteLine($"Salario neto después de impuestos y bono: {salary}");
        }

        static decimal CalculateNetSalary(decimal grossSalary)
        {
            // Calcular impuestos (18%)
            decimal tax = grossSalary * 0.18m;

            // Calcular bono (5%)
            decimal bonus = grossSalary * 0.05m;

            // Retornar salario neto
            return grossSalary - tax + bonus;
        }
    }
}