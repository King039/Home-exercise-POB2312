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
        Console.WriteLine("Пополнение счета прошло успешно. Пополнение баланса: " + balance);
    }

    public void Withdraw(double amount)
    {
        if (amount > balance)
        {
            Console.WriteLine("Недостаточно средств. Вывод средств не удался. ");
        }
        else
        {
            balance -= amount;
            Console.WriteLine("Вывод средств прошел успешно. Пополнение баланса: " + balance);
        }
    }

    public void CheckBalance()
    {
        Console.WriteLine("Текущий баланс: " + balance);
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
