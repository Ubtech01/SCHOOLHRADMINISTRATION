using HRAdminAPI;
using System.Collections.Generic;
using System;
using System.Linq;


namespace SCHOOLHRADMINISTRATION
{
    public class Program
    {
       

        static void Main(string[] args)
        {
            decimal totalSalaries = 0;

            List<IEmployee> employees = new List<IEmployee>();
            SeedData(employees);

            //foreach (IEmployee employee in employees)
            //{
            //    totalSalaries = employee.Salary;
            //}
            //Console.WriteLine($"Total Annual salaries (including bonus): {totalSalaries}");


            //Using linqs...................
            Console.WriteLine($"Total Annual salaries: {employees.Sum(e=>e.Salary)}");
            Console.ReadKey();
        }
        public static void SeedData (List<IEmployee> employees) 
        {
            IEmployee teacher1 = new Teacher
            {
                Id = 1,
                FirstName = "Ubong",
                LastName = "Akpan",
                Salary = 30000
            };
            employees.Add(teacher1);

            IEmployee teacher2 = new Teacher
            {
                Id = 2,
                FirstName = "John",
                LastName = "Doe",
                Salary = 40000
            };
            employees.Add(teacher2);

            IEmployee headOfDepartment = new HeadOfDepartment
            {
                Id = 3,
                FirstName = "Isaac",
                LastName = "Oguche",
                Salary = 60000
            };
            employees.Add (headOfDepartment);

            IEmployee deputyHeadMaster = new DeputyHeadMaster
            {
                Id = 4,
                FirstName = "Shalom",
                LastName = "Gar",
                Salary = 50000
            };
            employees.Add(deputyHeadMaster);

            IEmployee headMaster = new HeadMaster
            {
                Id = 5,
                FirstName = "John",
                LastName = "Doe",
                Salary = 40000
            };
            employees.Add(headMaster);
        }
    }
    public class Teacher : EmployeeBase
    {
         public override decimal Salary { get => base.Salary + (base.Salary * 0.02m);}                                                                                                                                                                                
    }
    public class HeadOfDepartment : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.03m);}
    }
    public class DeputyHeadMaster : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.04m);}
    }
    public class HeadMaster : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.05m);}
    }
}
