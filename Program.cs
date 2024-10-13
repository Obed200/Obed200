using System;

namespace Program
{
    class MTNServices
    {
        
        void Showbalance(double balance)
        {
            Console.WriteLine($"Your current balance is: ${balance}\n");
        }

        
        double Deposit()
        {
            double amount = 0;
            Console.WriteLine("Enter amount to deposit:");
            amount = Convert.ToDouble(Console.ReadLine());

            if (amount > 0)
            {
                return amount;
            }
            else
            {
                Console.WriteLine("Invalid amount. Please enter a positive number.");
                return 0;  
            }
        }

        
        double Withdraw(double balance)
        {
            double amount = 0;
            Console.WriteLine("Enter amount to withdraw:");
            amount = Convert.ToDouble(Console.ReadLine());

            if (amount > 0 && amount <= balance)
            {
                return amount;
            }
            else
            {
                Console.WriteLine("Invalid amount. Please ensure it's positive and does not exceed your balance.");
                return 0;  
            }
        }

        
        static void Main(string[] args)
        {
            MTNServices mtnServices = new MTNServices();  // Create an instance of the class
            double balance = 0;  
            int choice;

            do
            {
                
                Console.WriteLine("Enter your choice:");
                Console.WriteLine("1. Show Balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Exit");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        mtnServices.Showbalance(balance);
                        break;
                    case 2:
                        balance += mtnServices.Deposit();
                        mtnServices.Showbalance(balance);
                        break;
                    case 3:
                        balance -= mtnServices.Withdraw(balance);
                        mtnServices.Showbalance(balance);
                        break;
                    case 4:
                        Console.WriteLine("Thank you for using our service! Come back again.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

            } while (choice != 4);  
        }
    }
}
