using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekProj3
{
    class Program
    {
        static void Main(string[] args)
        {
            ////this is how we instantiate a new client
            Client client1 = new Client("Roxy", "216-967-2434", "Duckburg address");
            Checking checkA = new Checking("Checking", 619858458, 4000 );
            Savings savA = new Savings("Savings", 828224631, 6000, 200 );


            //Greeting!
            Console.WriteLine("Hello and welcome to WCC-IT International Bank!  Please enter your full name!");
            client1.Name = Console.ReadLine();


            Console.WriteLine("\nWelcome back " + client1.Name + " what would you like to do?");

            int selectedOption;


            do
            {
                Console.WriteLine();
                Console.WriteLine("\nPlease select an option: ");
                Console.WriteLine("\n1. View Client Information");
                Console.WriteLine("\n2. View Account Balance");
                Console.WriteLine("\n3. Deposit Funds");
                Console.WriteLine("\n4. Withdraw Funds");
                Console.WriteLine("\n5. Exit");

                bool trueF;
                trueF = int.TryParse(Console.ReadLine(), out selectedOption);


                while (trueF == false)
                {
                    Console.Write("I'm sorry " + client1.Name + " but, it appears the option you've selected is unavalable, please choose another.:\n");
                    trueF = int.TryParse(Console.ReadLine(), out selectedOption);
                }
                if (trueF == true)
                {

                    //Client Information

                    while (selectedOption == 1)
                    {
                        client1.ClientInfo();
                        break;
                    }


                    /*Account Balance! */

                    while (selectedOption == 2)
                    {
                        checkA.ViewBalance();
                        string balance = Console.ReadLine();
                        balance = balance.ToUpper();

                        if (balance.ToUpper() == "A")
                        {
                            Console.WriteLine("The Balance in your checking account is: $" + checkA.CheckingAccount + "!");
                            break;
                        }

                        else if (balance.ToUpper() == "B")
                        {
                            Console.WriteLine("The Balance in your savings account is: $" + savA.SavingsAccount + "!");
                            break;
                        }

                        else
                        {
                            Console.WriteLine("I'm very sorry " + client1.Name + ", but it seems the option you selected was invalid! \nPlease try again.: ");
                            balance = Console.ReadLine();
                            balance = balance.ToUpper();
                        }
                    }

                    /*Deposit Funds */

                    while (selectedOption == 3)
                    {
                        Console.WriteLine("Would you like to place the deposit in your Checking or Savings account?");
                        Console.WriteLine("\nA. To Checking Account");
                        Console.WriteLine("\nB. To Savings Account");
                        string selection = Console.ReadLine();
                        selection = selection.ToUpper();

                        if (selection.ToUpper() == "A")
                        {
                            Console.WriteLine("How much would you like to deposite into your checking account?");
                            double desiredAmount = double.Parse(Console.ReadLine());
                            checkA.Deposit(desiredAmount);

                            Console.WriteLine("You now have $" + checkA.CheckingAccount + " in your Checking Account!");
                            break;
                        }
                        else if (selection.ToUpper() == "B")
                        {
                            Console.WriteLine("How much would you like to deposite into your Savings account ?");
                            double desiredAmount = double.Parse(Console.ReadLine());
                            savA.Deposit(desiredAmount);

                            Console.WriteLine("You now have $" + savA.SavingsAccount + " in your Savings Account!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("I'm very sorry " + client1.Name + ", but it seems the option you selected was invalid! \nPlease try again.: ");
                            selection = Console.ReadLine();
                            selection = selection.ToUpper();
                        }
                    }


                    /*Withdraw Funds! */

                    while (selectedOption == 4)
                    {
                        Console.WriteLine("Would you like to withdraw from your Checking or Savings account?");
                        Console.WriteLine("\nA. From Checking Account");
                        Console.WriteLine("\nB. From Savings Account");
                        string withdraw = Console.ReadLine();
                        withdraw = withdraw.ToUpper();

                        if (withdraw.ToUpper() == "A")
                        {
                            if (checkA.CheckingAccount >= 0)
                            {
                                Console.WriteLine("How much would you like to withdraw from your checking account?");
                                double desiredAmount = double.Parse(Console.ReadLine());
                                checkA.Withdraw(desiredAmount);

                                Console.WriteLine("You now have $" + checkA.CheckingAccount + " left in your Checking Account!");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("I'm sorry, but it looks like your account has been overdrafted and cannot be withdrawn from at this time!");
                                break;
                            }
                        }
                        else if (withdraw.ToUpper() == "B")
                        {
                            if (savA.SavingsAccount >= 201)
                            {
                                Console.WriteLine("How much would you like to withdraw from your savings account?");
                                double desiredAmount = double.Parse(Console.ReadLine());
                                savA.Withdraw(desiredAmount);

                                Console.WriteLine("You now have $" + savA.SavingsAccount + " left in your Savings Account!");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Sorry, your savings account is at the Minimum Balance and cannot be withdrawn from at this time!");
                                savA.SavingsAccount = 200;
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("I'm very sorry " + client1.Name + ", but it seems the option you selected was invalid! \nPlease try again.: ");
                            withdraw = Console.ReadLine();
                            withdraw = withdraw.ToUpper();
                        }

                        //while ()
                    }


                    /*Exit!  */

                    if (selectedOption == 5)
                    {
                        Console.WriteLine("\nThank you for choosing WCC-IT International! \nHave a nice day!");
                        break;
                    }


                }

                while (savA.SavingsAccount <= savA.MinBalance)
                {
                    Console.WriteLine("Sorry, it looks like you Minimum Balance has been reached, you can not withdraw any more money from your Savings!");
                    savA.SavingsAccount = 200;
                    break;
                }

            } while (selectedOption != 5);




        }
    }
}
