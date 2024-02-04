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
    internal virtual double CalculateProtection(double damage)
    {
        PrintProtection(damage);
        return Shield.CalculateProtection(damage - Protection);
    }

    protected void PrintProtection(double damage)
    {
        Console.WriteLine($"Protection: {Protection}, Input Damage: {damage} Total Damage: {damage - Protection}\n");
    }
}

public class NoShield : ShieldProtection
{
    public NoShield()
    {
    }
    internal sealed override double CalculateProtection(double damage)
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

    internal sealed override double CalculateProtection(double damage)
    {
        PrintProtection(damage);
        return damage - Protection;
    }
}

public class Vest : ShieldProtection
{
    public Vest(ShieldProtection shield) : base(shield)
    {
        Protection =3;
    }
}