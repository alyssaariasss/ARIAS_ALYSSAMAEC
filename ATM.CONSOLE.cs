using System;

public class Program
{
	// first savings account
	class BankAccount 
	{
		private double balance = 100; 

		public void checkpin()
		{
			int loginAttempts = 0;
			
			for (int i = 0; i < 3; i++)
			{
				Console.WriteLine("\nEnter your five digit pin: \n\n");
				int pin = int.Parse(Console.ReadLine());

				if (pin != 02278)
				{
					loginAttempts++;
					Console.WriteLine("\nAccess denied. Please try again.\n\n");
					Console.WriteLine("Press enter to continue.");
					Console.ReadLine();
					Console.Clear();
				}

				else
				{
					Console.WriteLine("\nAccess granted.\n\n");
					Console.Clear();
					break;
				}
			}

			if (loginAttempts == 3)
			{
				Console.WriteLine("\nYou entered your pin incorrectly too many times. Access terminated.");
				System.Environment.Exit(1);
			}
		
		}

		public void myAccount()
		{
			string firstname = "Alyssa Mae";
			string middleinit = "C";
			string lastname = "Arias";
			Console.WriteLine($"\n\nWelcome {firstname} {middleinit}. {lastname}!\n\n");
			
		}

		public void transfer()
		{
			balance = 5000;

			Console.WriteLine("Enter account number");
			int accnum = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Checking account...");
			Console.ReadLine();
			Console.Clear();

			do
			{
				if (accnum == 00126789210)
				{
					Console.WriteLine("Welcome to Choleng's Bank Account!\n\n");
					Console.WriteLine("Balance: {0} \n\n\n", balance);
					break;
				}

				else
				{
					Console.WriteLine("Account not found. Please try again.");
					Console.ReadLine();
					Console.Clear();
				}
			}
			while (true);

		}

		public void withdraw(Double num) 
		{
			if (num > balance)
			{
				Console.WriteLine("\nInsufficient balance. Please try again.\n\n\n");
				Console.WriteLine("Press enter to continue.");
				Console.ReadLine();
				Console.Clear();
			}

			else if (num > 10000)
			{
				Console.WriteLine("\n\nWarning! Maximum withdrawal amount must be Php 10,000.\n\n");
				Console.WriteLine("Press enter to continue.");
				Console.ReadLine();
				Console.Clear();
			}

			else if (num % 10 != 0)	
			{
				Console.WriteLine("\n\nWarning! Amount to be withdrawn must be a multiple of 10.\n\n");
				Console.WriteLine("Press enter to continue.");
				Console.ReadLine();
				Console.Clear();
			}


			else
			{
				balance -= num;

				if (balance < 100)
				{
					balance += num;
					Console.WriteLine("\n\nWarning! Your account will be terminated if your balance is lower than the maintaining balance.\n\n");
					Console.WriteLine("Press enter to continue.");
					Console.ReadLine();
					Console.Clear();
				}


				else if (num <= 0)
				{
					balance += num;
					Console.WriteLine("\nInvalid transaction. Please try again.\n\n");
					Console.WriteLine("Press enter to continue.");
					Console.ReadLine();
					Console.Clear();
				}

				else
				{
					Console.WriteLine("\nSuccessful transaction.\n");
					Console.WriteLine("Press enter to continue.");
					Console.ReadLine();
					Console.Clear();
				}
			}
			
		}

		public void deposit(Double num)
		{
			balance += num;

			if (num <= 0)
			{
				balance -= num;
				Console.WriteLine("\nInvalid transaction. Please try again.\n\n");
				Console.WriteLine("Press enter to continue.");
				Console.ReadLine();
				Console.Clear();
			}

			else
			{
				Console.WriteLine("\nSuccessful transaction.\n");
				Console.WriteLine("Press enter to continue.");
				Console.ReadLine();
				Console.Clear();
			}
		}

		public double getbalance()
		{
			return balance;
		}

		public double getnewbalance()
		{
			return balance;
		}
	}

	// second savings account
	class newBankAccount
	{
		private double balance = 1000;
		public void withdraw(Double num)
		{
			if (num > balance)
			{
				Console.WriteLine("\nInsufficient balance. Please try again.\n\n\n");
				Console.WriteLine("Press enter to continue.");
				Console.ReadLine();
				Console.Clear();
			}

			else if (num > 10000)
			{
				Console.WriteLine("\n\nWarning! Maximum withdrawal amount must be Php 10,000.\n\n");
				Console.WriteLine("Press enter to continue.");
				Console.ReadLine();
				Console.Clear();
			}

			else if (num % 10 != 0)
			{
				Console.WriteLine("\n\nWarning! Amount to be withdrawn must be a multiple of 10.\n\n");
				Console.WriteLine("Press enter to continue.");
				Console.ReadLine();
				Console.Clear();
			}

			else
			{
				balance -= num;

				if (balance < 100)
				{
					balance += num;
					Console.WriteLine("\n\nWarning! Your account will be terminated if your balance is lower than the maintaining balance.\n\n");
					Console.WriteLine("Press enter to continue.");
					Console.ReadLine();
					Console.Clear();
				}


				else if (num <= 0)
				{
					balance += num;
					Console.WriteLine("\nInvalid transaction. Please try again.\n\n");
					Console.WriteLine("Press enter to continue.");
					Console.ReadLine();
					Console.Clear();
				}

				else
				{
					Console.WriteLine("\nSuccessful transaction.\n");
					Console.WriteLine("Press enter to continue.");
					Console.ReadLine();
					Console.Clear();
				}
			}

		}

		public void deposit(Double num)
		{
			balance += num;

			if (num <= 0)
			{
				balance -= num;
				Console.WriteLine("\nInvalid transaction. Please try again.\n\n");
				Console.WriteLine("Press enter to continue.");
				Console.ReadLine();
				Console.Clear();
			}

			else
			{
				Console.WriteLine("\nSuccessful transaction.\n");
				Console.WriteLine("Press enter to continue.");
				Console.ReadLine();
				Console.Clear();
			}
		}

		public double getbalance()
		{
			return balance;
		}

		public double getnewbalance()
		{
			return balance;
		}
	}
	public static void Main()
	{
		BankAccount bankMain = new BankAccount();
		double wd, dp;
		string str;

		bankMain.checkpin();
		bankMain.myAccount();

		do
		{
			Console.WriteLine("Select your account type:\n0. Savings\n1. Checking\n\n");
			Console.WriteLine("Enter your choice:\n\n");
			int typechoice = Convert.ToInt32(Console.ReadLine());
			Console.ReadLine();
			Console.Clear();

			if (typechoice == 0)
			{
				do
				{
					Console.WriteLine("\t\tWelcome to your savings account!\n\n");
					Console.WriteLine("\t\t\t----------------------");
					Console.WriteLine("\t\t\tA T M  S E R V I C E S");
					Console.WriteLine("\t\t\t----------------------\n\n");
					Console.WriteLine("1. Check Account Balance\n2. Withdraw\n3. Deposit\n4. Transfer Money to Another Account\n 5. Exit Transaction\n\nEnter your choice:\n\n");
					str = Console.ReadLine();

					if (str != "1" && str != "2" && str != "3" && str != "4")
					{
						Console.WriteLine("\n\nInvalid transaction. Please try again.\n\n\n");
						Console.WriteLine("Press enter to continue.");
						Console.ReadLine();
						Console.Clear();
					}

					if (str == "1")
					{
						bankMain.getbalance();
						Console.WriteLine("\nYour balance is:  {0}\n\n\n\n", bankMain.getbalance().ToString());
						Console.WriteLine("Press enter to continue.");
						Console.ReadLine();
						Console.Clear();
					}

					if (str == "2")
					{
						Console.WriteLine("\nEnter an amount to withdraw:\n\n");
						wd = Convert.ToDouble(Console.ReadLine());
						bankMain.withdraw(wd);
					}

					if (str == "3")
					{
						Console.WriteLine("\nEnter an amount to deposit:\n\n");
						dp = Convert.ToDouble(Console.ReadLine());
						bankMain.deposit(dp);
					}

					if (str == "4")
					{
						bankMain.transfer();
						Console.WriteLine("Select your account type:\n0. Savings\n1. Checking\n\n");
						Console.WriteLine("Enter your choice:\n\n");
						Console.ReadLine();
						Console.Clear();
						Console.WriteLine("Enter amount to transfer:\n\n");
						int transferamt = Convert.ToInt32(Console.ReadLine());
						
						if (transferamt > 50000)
						{
							Console.WriteLine("\n\nWarning! Maximum withdrawal amount must be Php 50,000.\n\n");
							Console.WriteLine("Press enter to continue.");
							Console.ReadLine();
							Console.Clear();
						}
						else
						{
							bankMain.getbalance();
							Console.WriteLine("\nCholeng's balance is:  {0}\n\n\n\n", bankMain.getnewbalance().ToString());
							Console.WriteLine("Press enter to continue.");
							Console.ReadLine();
							Console.Clear();
						}


					}
					if (str == "5")
					{
						break;
					}
				}
				while (true);
				Console.WriteLine("\n\nThank you for banking with us!");
				System.Environment.Exit(0);
			}

			else if (typechoice == 1)
			{
				newBankAccount bankSecond = new newBankAccount();

				do
				{
					Console.WriteLine("\t\tWelcome to your new savings account!\n\n");
					Console.WriteLine("\t\t\t----------------------");
					Console.WriteLine("\t\t\tA T M  S E R V I C E S");
					Console.WriteLine("\t\t\t----------------------\n\n");
					Console.WriteLine("1. Check Account Balance\n2. Withdraw\n3. Deposit\n4. Transfer Money to Another Account\n 5. Exit Transaction\n\nEnter your choice:\n\n");
					str = Console.ReadLine();

					if (str != "1" && str != "2" && str != "3" && str != "4")
					{
						Console.WriteLine("\n\nInvalid transaction. Please try again.\n\n\n");
						Console.WriteLine("Press enter to continue.");
						Console.ReadLine();
						Console.Clear();
					}

					if (str == "1")
					{
						bankSecond.getbalance();
						Console.WriteLine("\nYour balance is:  {0}\n\n\n\n", bankSecond.getbalance().ToString());
						Console.WriteLine("Press enter to continue.");
						Console.ReadLine();
						Console.Clear();
					}

					if (str == "2")
					{
						Console.WriteLine("\nEnter an amount to withdraw:\n\n");
						wd = Convert.ToDouble(Console.ReadLine());
						bankSecond.withdraw(wd);
					}

					if (str == "3")
					{
						Console.WriteLine("\nEnter an amount to deposit:\n\n");
						dp = Convert.ToDouble(Console.ReadLine());
						bankSecond.deposit(dp);
					}

					if (str == "4")
					{
						bankMain.transfer();
						Console.WriteLine("Select your account type:\n0. Savings\n1. Checking\n\n");
						Console.WriteLine("Enter your choice:\n\n");
						Console.ReadLine();
						Console.Clear();
						Console.WriteLine("Enter amount to transfer:\n\n");
						int transferamt = Convert.ToInt32(Console.ReadLine());

						if (transferamt > 50000)
						{
							Console.WriteLine("\n\nWarning! Maximum withdrawal amount must be Php 50,000.\n\n");
							Console.WriteLine("Press enter to continue.");
							Console.ReadLine();
							Console.Clear();
						}
						else
						{
							bankMain.getbalance();
							Console.WriteLine("\nCholeng's balance is:  {0}\n\n\n\n", bankMain.getnewbalance().ToString());
							Console.WriteLine("Press enter to continue.");
							Console.ReadLine();
							Console.Clear();
						}


					}
					if (str == "5")
					{
						break;
					}
				}
				while (true);
				Console.WriteLine("\n\nThank you for banking with us!");
				System.Environment.Exit(0);
			}

			else
			{
				Console.WriteLine("Invalid choice. Please try again.\nPress enter to continue.\n\n");
				Console.ReadLine();
				Console.Clear();
			}
		}
		while (true) ;

		
	}
}
