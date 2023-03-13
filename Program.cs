﻿// See https://aka.ms/new-console-template for more information
using ExLista;
using System.Globalization;

Console.Write("How many employees will be regitered? ");
int n = int.Parse(Console.ReadLine());
Employee employee;
List<Employee> list = new List<Employee>();

for (int i = 1; i <= n; i++)
{
    Console.WriteLine();
    Console.WriteLine($"Employee #{i}");
    Console.Write("Id: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Salary: ");
    double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    employee = new Employee(id, name, salary);
    list.Add(employee);
}

Console.WriteLine();
Console.Write("Enter the employee id that will have salary increase: ");
int idEmployee = int.Parse(Console.ReadLine());

List<Employee> employee2 = list.FindAll(x => x.Id == idEmployee);
if (employee2 == null)
    Console.WriteLine("This id does not exist!");
else
{
    foreach (Employee emp in employee2)
    {
        Console.Write("Enter the percentage: ");
        double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        emp.increaseSalary(percentage);
    }
}


Console.WriteLine();
Console.WriteLine("Updated list of employees: ");
foreach (Employee emp in list)
{
    Console.WriteLine(emp);
}
