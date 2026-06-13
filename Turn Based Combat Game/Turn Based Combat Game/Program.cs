namespace Turn_Based_Combat_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Unit player = new Unit(100, 20, 12, "Pepe");
            Unit enemy = new Unit(80, 15, 25, "Enemy Mage");
            Console.WriteLine(player.Hp + "HP = " + player.UnitName);
            Console.WriteLine(enemy.Hp + "HP = " + enemy.UnitName);
            while (!player.IsDead && !enemy.IsDead)
            {
                Console.WriteLine("Player turn! What will you do?");
                string choice = Console.ReadLine();

                if (choice == "a")
                {
                    player.Attack(enemy);
                    Console.WriteLine(enemy.Hp + " HP = " + enemy.UnitName);

                }
                else
                {
                    player.Heal();//Primero cura y luego calcula el HP actual del player y del enemigo
                    Console.WriteLine(player.UnitName + " HP " + player.Hp + enemy.UnitName + " HP " + enemy.Hp);
                }

                Console.WriteLine("Enemy turn!");

                int rand = random.Next(0, 2);  // devuelve un número entre 0 y 1 (Excluye el máximo) 

                if (rand == 0)
                {
                    enemy.Attack(player);
                }
                else
                {
                    enemy.Heal();
                }

                if (player.IsDead || enemy.IsDead) break;

            }

            if (player.Hp > enemy.Hp)
            {
                Console.WriteLine("Player Pepe wins");
            }
            else
            {
                Console.WriteLine("Enemy Mage wins");
            }
        }
    }
}