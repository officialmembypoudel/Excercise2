namespace Excercise2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Running, Program!");

        BankAccount ba = new BankAccount("s100");
        ba.Deposit(1000);
        ba.Withdraw(500);
        ba.ShowBalance();

        Console.ReadKey();
    }
}

