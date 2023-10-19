using System;
namespace H_W_14._10._23
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bank account");
            BankAccount account = new BankAccount(1000, BankAccountType.Checking);
            Console.WriteLine("Account Number: {0}", account.AccountNumber);
            Console.WriteLine("Balance: ${0}", account.Balance);
            Console.WriteLine("Account Type: {0}", account.AccountType);
            Console.WriteLine("Do you want withdraw (write 1) or deposit (write 2), otherwise write - 3");
            bool flag;
            int a;
        Patch:
            flag = int.TryParse(Console.ReadLine(), out a);
            if (flag == false)
            {
                Console.WriteLine("Unknown command!");
                goto Patch;
            }
            else if (a == 1)
            {
                flag = false;
                while (flag != true)
                {
                    Console.WriteLine("What amount in $ do you want to Withdraw");
                    decimal WD;
                    flag = decimal.TryParse(Console.ReadLine(), out WD);
                    if (flag == false)
                    {
                        Console.WriteLine("It's not number!");
                    }
                    else
                    {
                        account.Withdraw(WD);
                        Console.WriteLine("New Balance: ${0}", account.Balance);
                    }

                }
            }
            else if (a == 2)
            {
                flag = false;
                while (flag != true)
                {
                    Console.WriteLine("What amount in $ do you want to Deposit");
                    decimal Dep;
                    flag = decimal.TryParse(Console.ReadLine(), out Dep);
                    if (flag == false)
                    {
                        Console.WriteLine("It's not number!");
                    }
                    else
                    {
                        account.Deposit(Dep);
                        Console.WriteLine("New Balance: ${0}", account.Balance);
                    }
                }
            }
            else if (a == 3)
            {

            }
            else
            {
                Console.WriteLine("Unknown command!");
                goto Patch;
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
