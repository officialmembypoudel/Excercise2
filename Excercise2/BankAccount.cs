using System;
namespace Excercise2
{
	public class BankAccount
	{
		private string accountNumber;
		private decimal balance = 0;
		public BankAccount(string accountNumber)
		{
			this.accountNumber = accountNumber;
		}

		public void Deposit(decimal amount)
		{
			balance += amount;
		}

		public void Withdraw(decimal amount)
		{
			balance -= amount;
		}

		public void ShowBalance()
		{
			Console.WriteLine($"The remaining balance of {accountNumber} account is ${balance}.");
		}
	}
}

