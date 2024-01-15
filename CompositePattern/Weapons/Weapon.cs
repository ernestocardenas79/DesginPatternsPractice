namespace Weapons;
public abstract class Weapon
{
    public int damage { get; init; }
    public Weapon(int damage)
    {
        this.damage = damage;
    }

}

public class Gun : Weapon
{
    public Gun() : base(10) { }
}

public class ShotGun : Weapon
{
    public ShotGun() : base(30) { }
}

public class MachineGun : Weapon
{
    public MachineGun() : base(19) { }
}