using Weapons;

namespace Players.Additions;

public abstract class PlayerWithAdditions : Player
{
    protected Player Player { get; init; }
    public PlayerWithAdditions(Player player)
    {
        Player = player;
    }
}

public class MeshTshirt : PlayerWithAdditions
{
    public MeshTshirt(Player player) : base(player)
    {
        life = player.life;
    }

    protected override void HandleAttack(Weapon weapon)
    {
        life -= int.Parse((weapon.damage * .3).ToString());
    }
}

public class Vest : PlayerWithAdditions
{
    public Vest(Player player) : base(player) { }

    protected override void HandleAttack(Weapon weapon)
    {
        throw new NotImplementedException();
    }
}

public class ArmoredVest : PlayerWithAdditions
{
    public ArmoredVest(Player player) : base(player) { }

    protected override void HandleAttack(Weapon weapon)
    {
        throw new NotImplementedException();
    }
}