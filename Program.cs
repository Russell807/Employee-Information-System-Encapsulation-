using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Xml.Linq;
using Encapsulation;

internal class Program
{
    private static List<Employee> employees = new List<Employee>();

    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Welcome to employee records. Please select what you want to perform:");
            Console.WriteLine("Press 1 to create a record.");
            Console.WriteLine("Press 2 to read a record.");
            Console.WriteLine("Press 3 to update a record.");
            Console.WriteLine("Press 4 to delete a record.");
            Console.WriteLine("Press 5 to exit.");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    CreateRecord();
                    break;
                case 2:
                    ReadRecord();
                    break;
                case 3:
                    UpdateRecord();
                    break;
                case 4:
                    DeleteRecord();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    public static void CreateRecord()
    {
        Employee employee = new Employee();

        Console.WriteLine("Full Name (FN MI. LN):");
        employee.SetName(Console.ReadLine());

        Console.WriteLine("Salary:");
        employee.SetSalary(Console.ReadLine());

        Console.WriteLine("Department (e.g IT, HR, Finance):");
        employee.SetDepartment(Console.ReadLine());

        Console.WriteLine("PIN:");
        employee.SetPIN(Convert.ToInt32(Console.ReadLine()));

        employees.Add(employee);
        Console.WriteLine("Record created successfully.");
    }

    public static void ReadRecord()
    {
        Console.WriteLine("Enter PIN to read the record:");
        int pin = Convert.ToInt32(Console.ReadLine());

        Employee employee = employees.Find(e => e.GetPIN() == pin);
        if (employee != null)
        {
          
            employee.readRecords();
        }
        else
        {
            Console.WriteLine("Record not found.");
        }
    }

    public static void UpdateRecord()
    {
        Console.WriteLine("Enter PIN to update the record:");
        int pin = Convert.ToInt32(Console.ReadLine());

        Employee employee = employees.Find(e => e.GetPIN() == pin);
        if (employee != null)
        {
            Console.WriteLine("Full Name (FN MI. LN):");
            employee.SetName(Console.ReadLine());

            Console.WriteLine("Salary:");
            employee.SetSalary(Console.ReadLine());

            Console.WriteLine("Department (e.g IT, HR, Finance):");
            employee.SetDepartment(Console.ReadLine());

            Console.WriteLine("Record updated successfully.");
        }
        else
        {
            Console.WriteLine("Record not found.");
        }
    }

    public static void DeleteRecord()
    {
        Console.WriteLine("Enter PIN to delete the record:");
        int pin = Convert.ToInt32(Console.ReadLine());

        Employee employee = employees.Find(e => e.GetPIN() == pin);
        if (employee != null)
        {
            employees.Remove(employee);
            Console.WriteLine("Record deleted successfully.");
        }
        else
        {
            Console.WriteLine("Record not found.");
        }
    }
}