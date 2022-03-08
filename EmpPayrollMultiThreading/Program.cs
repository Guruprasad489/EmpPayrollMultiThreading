using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpPayrollMultiThreading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee payroll using multithreading");

            List<EmployeeDetails> employeeDetails = new List<EmployeeDetails>();
            employeeDetails.Add(new EmployeeDetails { EmployeeID = 1, EmployeeName = "Guru" });
            employeeDetails.Add(new EmployeeDetails { EmployeeID = 2, EmployeeName = "Guruprasad" });
            employeeDetails.Add(new EmployeeDetails { EmployeeID = 3, EmployeeName = "Vikas" });
            employeeDetails.Add(new EmployeeDetails { EmployeeID = 4, EmployeeName = "Deepak" });

            EmployeePayrollOperations employeePayrollOperations = new EmployeePayrollOperations();
            Stopwatch stopWatch1 = new Stopwatch();
            stopWatch1.Start();
            employeePayrollOperations.AddEmployeeToPayroll(employeeDetails);
            stopWatch1.Stop();
            Console.WriteLine("Duration without multi thread: " + stopWatch1.ElapsedMilliseconds);
            Console.WriteLine("-------------------");

            Stopwatch stopWatch2 = new Stopwatch();
            stopWatch2.Start();
            employeePayrollOperations.AddEmployeeToPayrollWithThread(employeeDetails);
            stopWatch2.Stop();
            Console.WriteLine("Duration with multi thread: " + stopWatch1.ElapsedMilliseconds);
            Console.WriteLine("Employee count" + employeePayrollOperations.EmployeeCount());
            Console.WriteLine("-------------------");

            Console.ReadLine();
        }
    }
}
