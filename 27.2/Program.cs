using System;

class BankAccount
{
    private double balance;

    public BankAccount(double initialBalance)
    {
        balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine("Deposit successful. New balance: " + balance);
    }

    public void Withdraw(double amount)
    {
        if (amount > balance)
        {
            Console.WriteLine("Insufficient funds. Withdrawal failed.");
        }
        else
        {
            balance -= amount;
            Console.WriteLine("Withdrawal successful. New balance: " + balance);
        }
    }

    public void CheckBalance()
    {
        Console.WriteLine("Current balance: " + balance);
    }
}

class Program
{
    static void Main()
    {
        BankAccount myAccount = new BankAccount(1000);

        myAccount.CheckBalance();

        myAccount.Deposit(500);
        myAccount.Withdraw(200);
        myAccount.CheckBalance();
    }
}
