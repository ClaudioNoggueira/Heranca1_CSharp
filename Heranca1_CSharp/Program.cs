using Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Heranca1_CSharp {
    class Program {
        static void Main(string[] args) {
            List<Employee> employees = new List<Employee>();
            
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine("\nEmployee #" + i + " data:");
                Console.Write("Outsourced (y/n)? ");

                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'y') {
                    Console.Write("Additional charge: ");
                    double additionCharge = double.Parse(Console.ReadLine());
                    employees.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionCharge));
                }
                else {
                    employees.Add(new Employee(name, hours, valuePerHour));
                }
            }
            Console.WriteLine("\nPAYMENT");
            foreach (Employee item in employees) {
                Console.WriteLine(item.Name + " - R$ " + item.Payment().ToString("F2"));
            }
        }
    }
}
