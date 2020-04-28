using System;
using System.Collections;
using System.Linq;
using System.Text;
namespace Rock_Paper_Scissors
{
    class Program
    {
        public static void Main(string[] args)
        {
            string inputPlayer;
            int randomInt;
            int scorePlayer = 0;
            int scoreCPU = 0;
            bool playAgain = true;

            while (playAgain)
            {
                while (scorePlayer <= 4 && scoreCPU <= 4)
                {

                    Console.WriteLine(" 1 Rock 2 Paper 3 scissors. Please press enter after picking. Who ever gets  " +
                    " five points" +
                    " wins");
                    inputPlayer = Console.ReadLine();


                    inputPlayer = inputPlayer.ToLower();


                    Random rnd = new Random();
                    randomInt = rnd.Next(1, 3);

                    switch (randomInt)
                    {
                        case 1: // Rock


                            if (inputPlayer == "Rock")
                            {
                                Console.WriteLine("We have a Tie!!!\n\n");
                            }
                            else if (inputPlayer == "Paper")
                            {
                                Console.WriteLine("Player wins!!!\n\n");
                                scorePlayer++;
                            }
                            else // Scissors
                            {
                                Console.WriteLine("Computer wins!!!\n\n");
                                scoreCPU++;
                            }


                            break;

                        case 2: // Paper
                            Console.WriteLine("computer chose Paper");
                            if (inputPlayer == "paper")
                            {
                                Console.WriteLine("We have a Tie\n\n");
                            }
                            else if (inputPlayer == "Scissors")
                            {
                                Console.WriteLine("player wins the cheese!!!\n\n");
                                scorePlayer++;
                            }

                            else if (inputPlayer == "Paper")

                                Console.WriteLine("We have a bow TIE\n\n");

                            break;


                        case 3: //Scissors
                            Console.WriteLine("computer chose Scissors");
                            if (inputPlayer == "Scissors")

                            {
                                Console.WriteLine("We have a sad tie\n\n");
                            }
                            else if (inputPlayer == "Rock")

                            {
                                Console.WriteLine("you have crushed me\n\n");
                                scorePlayer++;


                            }
                            else if (inputPlayer == "Scissors")

                                Console.WriteLine("We got nowhere with this Draw");



                            break;
                    }

                    Console.WriteLine("Player: {1} \n CPU: {1}", scorePlayer, scoreCPU);
                }

                if (scorePlayer == 5)
                {
                    Console.WriteLine("Winner Winner Chicken DINNER");

                    Console.WriteLine("CPU wins You are a loser!!");


                }
                else
                {



                    Console.WriteLine("Do you wanna play again?(y/n)");
                    string loop = Console.ReadLine();

                    playAgain = loop.ToUpper() == "y";
                    // (loop == "y");
                    // playAgain = true;

                    //if (loop == "n");
                    // playAgain = false;

                }
            }
        }
    }
}