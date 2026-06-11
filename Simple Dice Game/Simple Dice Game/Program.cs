using System.ComponentModel.Design;

namespace Simple_Dice_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerrandomNumber;
            int enemyRandomNumber;
            int playerPoints = 0;//como es un contador hay q inicializarlo
            int enemyPoints = 0;
            Random ranm = new Random();

            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine("Press any key to roll the dice");
                Console.ReadKey();
                playerrandomNumber = ranm.Next(1, 7);
                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("You rolled a " + playerrandomNumber);
                enemyRandomNumber = ranm.Next(1, 7);
                Console.WriteLine("Enemy AI rolled a " + enemyRandomNumber);
                if (playerrandomNumber > enemyRandomNumber)
                {
                    playerPoints++;
                    Console.WriteLine("Player wins this round");
                }
                else if (enemyRandomNumber > playerrandomNumber)

                {
                    enemyPoints++;
                    Console.WriteLine("Enemy wins this round");

                }


                else
                {

                    Console.WriteLine("Draw!!");




                }
                Console.WriteLine("The score is now - Player : " + playerPoints + " Enemy: " + enemyPoints);
                Console.WriteLine();
            }
            if (playerPoints > enemyPoints)
            {
                Console.WriteLine("You win");
            }
            else if (enemyPoints > playerPoints)
            {
                Console.WriteLine("You lose");
            }
            else
            {
                Console.WriteLine("Draw");
            }
        }
    }
}

