namespace Turn_Based_Combat_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Unit player = new Unit(100,20,12,"Pepe");
            Unit enemy = new Unit(80, 15, 25, "Enemy Mage");
            Console.WriteLine(player.Hp + "HP = " + player.UnitName);
            Console.WriteLine(enemy.Hp + "HP = " + enemy.UnitName);
            Console.WriteLine("Player turn! What will you do?");
            string choice = Console.ReadLine();

            if (choice == "a")
            {
                player.Attack(enemy);
                Console.WriteLine(enemy.Hp + "HP = " + enemy.UnitName);

            }
        }
    }
}
