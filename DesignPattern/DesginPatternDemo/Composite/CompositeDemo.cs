﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成
//     如果重新生成代码，将丢失对此文件所做的更改。
// </auto-generated>
//------------------------------------------------------------------------------
namespace Composite
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class CompositeDemo
    {
        public void Main()
        {
            Employee CEO = new Employee() { Name = "John", Department = "CEO", Subordinates = new List<Employee>() };
            Employee headSales = new Employee() { Name = "Robert", Department = "Head Sales", Subordinates = new List<Employee>() };
            Employee headMarketing = new Employee() { Name = "Michel", Department = "Head Marketing", Subordinates = new List<Employee>() };
            Employee clerk1 = new Employee() { Name = "Laura", Department = "Marketing", Subordinates = new List<Employee>() };
            Employee clerk2 = new Employee() { Name = "Bob", Department = "Marketing", Subordinates = new List<Employee>() };
            Employee salesExecutive1 = new Employee() { Name = "Richard", Department = "Sales", Subordinates = new List<Employee>() };
            Employee salesExecutive2 = new Employee() { Name = "Rob", Department = "Sales", Subordinates = new List<Employee>() };

            CEO.Subordinates.Add(headSales);
            CEO.Subordinates.Add(headMarketing);

            headSales.Add(salesExecutive1);
            headSales.Add(salesExecutive2);

            headMarketing.Add(clerk1);
            headMarketing.Add(clerk2);

            Console.WriteLine($"{CEO.Name},{CEO.Department}");
            foreach (var headEmployee in CEO.Subordinates)
            {
                Console.WriteLine($"{headEmployee.Name},{headEmployee.Department}");
                foreach (var employee in headEmployee.Subordinates)
                {
                    Console.WriteLine($"{employee.Name},{employee.Department}");
                }
            }
        }
    }
}

