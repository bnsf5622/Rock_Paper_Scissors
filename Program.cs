using System;

namespace Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;
            int scorePlayer = 0;
            int scoreCPU = 0;
            bool playAgain = true;

            while (playAgain)
            {

            }
            while (scorePlayer < 3 && scoreCPU < 3)
            {
                Console.WriteLine("Do you want to play Rock Paper Scissors?");
                inputPlayer = Console.ReadLine();
                inputCPU = inputPlayer.ToUpper();

                Random rnd = new Random();

                randomInt = rnd.Next(1, 4);

                switch (randomInt)
                {
                    case 1:
                        inputCPU = "rock";
                        Console.WriteLine("Computer chose rock");
                        if (inputPlayer == "rock")
                        {
                            Console.WriteLine("Tie!!!\n\n");
                        }
                        else if (inputPlayer == "paper");
                        {
                            Console.WriteLine("Player wins!!!\n\n");
                                scorePlayer++;
                        
                       
                        else if (inputPlayer == "rock")
                        {
                            Console.WriteLine("Tie\n\n");
                        }
                        break;
                    case 2:
                        inputCPU = "Paper";

                        Console.WriteLine("Computer chose paper");
                        if (inputPlayer == "paper")
                        {
                            Console.WriteLine("Tie!!!\n\n");
                        }
                        else if (inputPlayer == "rock")
                        {
                            Console.WriteLine("cpu wins!!!\n\n");
                            scorePlayer++;
                        }
                        else if (inputPlayer == "scissors")
                        {
                            Console.WriteLine("player wins\n\n");
                            scoreCPU++;

                        }
                        break;


                    case 3:
                        inputCPU = "scissors";
                        Console.WriteLine("Computer chose scissors");
                        if (inputPlayer == "scissors")
                        {
                            Console.WriteLine("Tie!!!");

                        }
                        else if (inputPlayer == "rock")
                        {
                            Console.WriteLine("Player wins\n\n");
                            scorePlayer++;
                        }
                        else if (inputPlayer == "paper")
                        {
                            Console.WriteLine("CPU wins!!!\n\n")
                        }
                        break;
                    default:
                        Console.WriteLine("invalid");
                        break;
                }
            }
            if (scorePlayer == 3)
            {
                Console.WriteLine("Player won");
            }
            else if (scoreCPU == 3)

                Console.WriteLine("CPU won");
        }
        else
        {
        }
        Console.WriteLine("Play Again?");

    }
}