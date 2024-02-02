using System.Globalization;
using Weapons;

namespace Players.Shields;

public abstract class ShieldProtection
{
    protected ShieldProtection Shield { get; init; }
    protected int Protection {get; init;}
    public ShieldProtection()
    { }
    public ShieldProtection(ShieldProtection shield)
    {
        Shield = shield;
    }
    public abstract double CalculateProtection(double damage);
}

public class NoShield : ShieldProtection
{
    public NoShield()
    {
    }

    public override double CalculateProtection(double damage)
    {
        return damage;
    }
}

public class MeshTshirt : ShieldProtection
{
    public MeshTshirt(ShieldProtection shield) : base(shield)
    { 
        Protection =1;
    }

    public override double CalculateProtection(double damage)
    {
        Console.WriteLine($"Mesh Protection: {Protection}, Input Damage: {damage} Total Damage: {damage - Protection}\n");

        return damage - Protection;
    }
}

public class Vest : ShieldProtection
{
    public Vest(ShieldProtection shield) : base(shield)
    {
        Protection =3;
    }

    public override double CalculateProtection(double damage)
    {
        Console.WriteLine($"Vest Protection: {Protection}, Input Damage: {damage} Total Damage: {damage - Protection}\n");

        return Shield.CalculateProtection(damage - Protection);
    }
}