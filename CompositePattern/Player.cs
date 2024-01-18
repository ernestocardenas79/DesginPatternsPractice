using System.Globalization;
using Players.Shields;
using Weapons;

namespace Players;

public abstract class Player
{
    public string Name { get; init; } = "";

    internal int life { get; set; } = 100;
    public Weapon Weapon { get; set; } = new Gun() { Name = "Gun" };
    public ShieldProtection Shield { get; set; } = new NoShield();
    public void Attack(Player player)
    {
        Console.WriteLine("********************************\n\n\n");
        Console.WriteLine($"I've attacked with a {Weapon.Name} to {player.Name}, Damage of {Weapon.Damage}: Life= {player.life}\n");

        player.HandleAttack(this.Weapon);
    }

    public virtual void HandleAttack(Weapon weapon)
    {
        var shieldProtection = (int)Math.Round(Shield.CalculateProtection(weapon.Damage));
        Console.WriteLine($"{Name}: Total Shield Protection: {shieldProtection}, life={life}, TotalLife= {life - shieldProtection}\n");

        life = life - shieldProtection;
    }
}

public class PlayerLvl1 : Player
{
}