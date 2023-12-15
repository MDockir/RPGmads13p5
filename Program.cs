using RPGmads13p5;
using System.Threading;

class Program
{
    static void Main()
    {
        // Creating a player and Monster," initial health (HP) of 150, initial experience points (XP) of 0.
        Player player = new Player("Mads", 150, 0, PlayerType.Human);
        Monster monster = new Monster("Djævlen", 150, 0);

        Console.WriteLine("Battle Start!\n");

        // Continue the battle until either the player or the monster is defeated.
        while (!player.IsDead() && !monster.IsDead())
        {
            player.Attack();
            monster.Damage(15); // Simulate monster taking damage

            // Check if the monster is still alive before allowing it to attack
            if (!monster.IsDead())
            {
                monster.Attack();
                player.Damage(5); // Simulate player taking damage
            }

            Console.WriteLine($"Player HP: {player.HP1}, Monster HP: {monster.HP1}\n");
        }

        // Check the outcome of the battle and display a corresponding message
        if (player.IsDead())
        {
            Console.WriteLine("Player has been defeated!");
        }
        else
        {
            Console.WriteLine("Monster has been defeated!");
        }



    }
}

