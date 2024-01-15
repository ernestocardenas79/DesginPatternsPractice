using Weapons;

namespace Players;

public abstract class Player
{
    internal int life { get; set; } = 100;
    public Weapon Weapon { get; set; } = new Gun();
    public void Attack(Player player)
    {
        player.HandleAttack(this.Weapon);
    }

    protected abstract void HandleAttack(Weapon weapon);
}

public class PlayerLvl1 : Player
{
    protected override void HandleAttack(Weapon weapon)
    {
        life -= weapon.damage;
    }
}