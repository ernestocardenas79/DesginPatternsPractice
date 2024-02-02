using Weapons;

namespace Players;

public abstract class Player
{
    public string Name { get; init; } = "";

    protected internal int Life { get; set; } = 100;

    protected int Protection {get; init;}

    public Weapon Weapon { get; set; } = new Gun() { Name = "Gun" };
    public void Attack(Player player)
    {
        Console.WriteLine("********************************\n\n\n");
        Console.WriteLine($"{Name} attacked {player.Name} with a {Weapon.Name} , Damage of {Weapon.Damage}: Life= {player.Life}\n");

        player.HandleAttack(this.Weapon);
    }

    protected void HandleAttack(Weapon weapon)
    {
        Console.WriteLine($"{Name}: life={Life}, Protection = {Protection}  Life after attack= {Life - weapon.Damage + Protection}\n");
        Life = Life - weapon.Damage + Protection;
    }
}

public class PlayerLvl1 : Player
{
}

public class PlayerLvl1WithMesh : Player
{
    public PlayerLvl1WithMesh()
    {
        Protection = 1;
    }
}

public class PlayerLvl1WithVelt : Player
{
    public PlayerLvl1WithVelt()
    {
        Protection = 3;
    }
}

public class PlayerLvl1WithMeshVelt : Player
{
    public PlayerLvl1WithMeshVelt()
    {
        Protection = 4;
    }
}

