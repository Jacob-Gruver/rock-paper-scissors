using System;

namespace rock_paper_scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Random rnd = new Random();


            bool play = true;

            while (play == true)
            {
                bool ret = true;

                while (ret == true)
                {
                    ret = false;

                    var compChoice = rnd.Next(1, 4);

                    Console.WriteLine("Choose Rock, paper, or Scissors.. ");

                    string choice = Console.ReadLine();

                    if (choice == "rock")
                    {
                        if (compChoice == 1)
                        {
                            Console.Clear();

                            System.Console.WriteLine("Rock cant play against rock.. try again!");

                            ret = true;
                        }
                        else if (compChoice == 2)
                        {
                            System.Console.WriteLine("Paper covers rock.. you loose.");
                        }
                        else
                        {
                            System.Console.WriteLine("Rock breaks scissors! You Win!");
                        }
                    }
                    else if (choice == "paper")
                    {
                        if (compChoice == 1)
                        {
                            System.Console.WriteLine("Paper covers rock! You Win!");
                        }
                        else if (compChoice == 2)
                        {
                            Console.Clear();

                            System.Console.WriteLine("Paper cant play against paper.. try again!");

                            ret = true;
                        }
                        else
                        {
                            System.Console.WriteLine("Scissors cut paper.. You loose.");
                        }
                    }
                    else if (choice == "scissors")
                    {
                        if (compChoice == 1)
                        {
                            System.Console.WriteLine("Rock breaks scissors.. You loose.");
                        }
                        else if (compChoice == 2)
                        {
                            System.Console.WriteLine("Scissors cut paper.. You Win!");
                        }
                        else
                        {
                            Console.Clear();

                            System.Console.WriteLine("Scissors cant play against scissors.. Try again!");

                            ret = true;
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("Hey! No Cheating!");

                        ret = true;
                    }
                }

                System.Console.WriteLine("Play again? y/n ");

                string gameCont = Console.ReadLine();

                if (gameCont != "y")
                {
                    play = false;
                }
                else
                {
                    Console.Clear();
                }
            }
        }
    }
}
