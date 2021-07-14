/*12.13 (Polymorphic Banking Program Using Account Hierarchy) Develop a polymorphic banking app using the Account hierarchy created in Exercise 11.8.
        Create an array of Account references to SavingsAccount and CheckingAccount objects. 
        For each Account in the array, allow the user to specify an amount of money to withdraw from the Account using method Debit and an amount of
        money to deposit into the Account using method Credit. As you process each Account, determine its type. If an Account is a SavingsAccount, 
        calculate the amount of interest owed to the Account using method CalculateInterest, then add the interest to the account balance using method Credit.
        After processing an Account, display the updated account balance obtained by using baseclass property Balance.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TestClass
{
    public static void Main(string[] args)
    {

        SavingsAccount saveAcc = new SavingsAccount(10, 0.05M, 500.00M);      //testing SavingAccount

        saveAcc.CalculateInterest();
        Console.WriteLine("Account with percentage for 10 mohts is: {0:C}", saveAcc.Balance);


        CheckingAccount checkAcc = new CheckingAccount(0.01M, 900.00M);         //testing CheckingAccount
        checkAcc.Credit(100.00M);
        Console.WriteLine("Account after credit 100.00M is: {0:C}", checkAcc.Balance);
        checkAcc.Debit(200.00M);
        Console.WriteLine("Account after debit 200.00M is: {0:C}", checkAcc.Balance);
        Console.WriteLine();

        SavingsAccount saveAcc1 = new SavingsAccount(3, 0.05M, 100.00M);
        SavingsAccount saveAcc2 = new SavingsAccount(4, 0.05M, 200.00M);
        SavingsAccount saveAcc3 = new SavingsAccount(5, 0.05M, 300.00M);
        SavingsAccount saveAcc4 = new SavingsAccount(6, 0.05M, 400.00M);
        SavingsAccount saveAcc5 = new SavingsAccount(7, 0.05M, 500.00M);
        CheckingAccount checkAcc1 = new CheckingAccount(0.02M, 1500.00M);
        CheckingAccount checkAcc2 = new CheckingAccount(0.03M, 1600.00M);
        CheckingAccount checkAcc3 = new CheckingAccount(0.04M, 1700.00M);
        CheckingAccount checkAcc4 = new CheckingAccount(0.05M, 1800.00M);
        CheckingAccount checkAcc5 = new CheckingAccount(0.06M, 1900.00M);

        Account[] array = new Account[10];              

        array[0] = saveAcc1;
        array[1] = saveAcc2;
        array[2] = saveAcc3;
        array[3] = saveAcc4;
        array[4] = saveAcc5;
        array[5] = checkAcc1;
        array[6] = checkAcc2;
        array[7] = checkAcc3;
        array[8] = checkAcc4;
        array[9] = checkAcc5;

        foreach (Account item in array)
        {
            if (item is SavingsAccount)
            {
                SavingsAccount NewElem = (SavingsAccount)item;
                NewElem.CalculateInterest();
            }
        }

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Enter withdraw for array {0}", i);
            array[i].Debit((Convert.ToInt32(Console.ReadLine())));
            Console.WriteLine("Enter deposit for array {0}", i);
            array[i].Credit((Convert.ToInt32(Console.ReadLine())));
        }
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Balance in array {0} is: {1:C}", i, array[i].Balance);
        }
        Console.ReadLine();
    }
}
