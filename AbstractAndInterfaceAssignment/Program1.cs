using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1.Write a C# program to create an abstract class BankAccount with abstract methods deposit() 
//and withdraw().
//Create subclasses: SavingsAccount and CurrentAccount that inherit the BankAccount class
//and implement the respective methods to handle deposits and withdrawals for each account type.


abstract class BankAccount
{
    public abstract void Deposit(decimal amount);
    public abstract void Withdraw(decimal amount);
}

class SavingsAccount : BankAccount
{
    private decimal balance;

    public SavingsAccount(decimal initialBalance)
    {
        balance = initialBalance;
    }

    public override void Deposit(decimal amount)
    {
        balance += amount;
        Console.WriteLine($"Savings Account Deposited: {amount}. New Balance: {balance}");
    }

    public override void Withdraw(decimal amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Savings Account Withdrawn: {amount}. Remaining Balance: {balance}");
        }
        else
        {
            Console.WriteLine("Insufficient balance in Savings Account.");
        }
    }
}

class CurrentAccount : BankAccount
{
    private decimal balance;

    public CurrentAccount(decimal initialBalance)
    {
        balance = initialBalance;
    }

    public override void Deposit(decimal amount)
    {
        balance += amount;
        Console.WriteLine($"Current Account Deposited: {amount}. New Balance: {balance}");
    }

    public override void Withdraw(decimal amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Current Account Withdrawn: {amount}. Remaining Balance: {balance}");
        }
        else
        {
            Console.WriteLine("Insufficient balance in Current Account.");
        }
    }
}

class Program1
{
    //static void Main()
    //{
    //    BankAccount savings = new SavingsAccount(1000);
    //    savings.Deposit(500);
    //    savings.Withdraw(200);

    //    BankAccount current = new CurrentAccount(2000);
    //    current.Deposit(1000);
    //    current.Withdraw(3000);
    //}
}
