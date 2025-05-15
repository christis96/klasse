
namespace klasse;

public class Pikachu
{
    public int Health { get; set; }
    public int Level { get; set; }
    
    public Pikachu(int health, int level)
    {
        Health = health;
        Level = level;
    }

    public void PrintStatus()
    {
        Console.WriteLine($"Pikachu is at level {Level} with {Health} HP.");
    }
}