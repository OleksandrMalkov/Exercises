/*12.11 (Payroll System Modification) Modify the payroll system of Figs. 12.4–12.9 to include an additional Employee derived class, PieceWorker, that represents an employee whose pay is based on
        the number of pieces of merchandise produced. Class PieceWorker should contain private instance variables wage (to store the employee’s wage per piece) and pieces 
        (to store the number of pieces produced). Provide a concrete implementation of method Earnings in class PieceWorker that calculates the employee’s earnings by multiplying the number 
        of pieces produced by the wage per piece. Create an array of Employee variables to store references to objects of each concrete class in the new Employee hierarchy.
        Display each Employee’s string representation and earnings.
 */
using System;

public class PayrollSystemTest
{
    static void Main(string[] args)
    {
        SalariedEmployee salariedEmployee = new SalariedEmployee("John", "Smith", "111-11-1111", 800.00M);
        HourlyEmployee hourlyEmployee = new HourlyEmployee("Karen", "Price", "222-22-222", 16.75M, 40.0M);
        CommissionEmployee commissionEmployee = new CommissionEmployee("Sue", "Jones", "333-33-333", 10000.00M, .06M);
        BasePlusCommissionEmployee basePlusCommissionEmployee = new BasePlusCommissionEmployee("Bob", "Lewis", "444-44-444", 5000.00M, .04M, 300.00M);
        PieceWorker pieceWorker = new PieceWorker("Anna", "Taylor", "555-55-555", 25.00M, 50);   // creating new PieceWorker class object


        Console.WriteLine("Employees prossed individually\n");
        Console.WriteLine("{0}\nearned: {1:C}", salariedEmployee, salariedEmployee.Earnings());
        Console.WriteLine("{0}\nearned: {1:C}\n", hourlyEmployee, hourlyEmployee.Earnings());
        Console.WriteLine("{0}\nearned: {1:C}\n", commissionEmployee, commissionEmployee.Earnings());
        Console.WriteLine("{0}\nearned: {1:C}\n", basePlusCommissionEmployee, basePlusCommissionEmployee.Earnings());
        Console.WriteLine("{0}\nearned: {1:C}\n", pieceWorker, pieceWorker.Earnings());                           //outputing new data of PieceWorker class object         


        Employee[] employees = new Employee[5];

        employees[0] = salariedEmployee;
        employees[1] = hourlyEmployee;
        employees[2] = commissionEmployee;
        employees[3] = basePlusCommissionEmployee;
        employees[4] = pieceWorker;                        //adding new reference to PieceWorker class object

        Console.WriteLine("Employees processed polymorphically:\n");

        foreach (Employee currentEmployee in employees)
        {
            Console.WriteLine(currentEmployee);

            if (currentEmployee is BasePlusCommissionEmployee)
            {
                BasePlusCommissionEmployee employee = (BasePlusCommissionEmployee)currentEmployee;
                employee.BaseSalary *= 1.10M;
                Console.WriteLine("new base salary with 10% increase is: {0:C}", employee.BaseSalary);
            }
            Console.WriteLine("earned {0:C}\n", currentEmployee.Earnings());
        }
        for (int j = 0; j < employees.Length; j++)
            Console.WriteLine("Employee {0} is a {1}", j,
            employees[j].GetType());

        Console.ReadLine();
    }
}
