using System.Globalization;
using Weapons;

namespace Players.Shields;

public abstract class ShieldProtection
{
    protected ShieldProtection Shield { get; init; }
    public ShieldProtection()
    { }
    public ShieldProtection(ShieldProtection shield)
    {
        Shield = shield;
    }
    public virtual double CalculateProtection(double damage)
    {
        Console.WriteLine($"Mesh Protection: {ProtectionFactor()}, Input Damage: {damage} Total Damage: {damage - ProtectionFactor()}\n");

        return Shield.CalculateProtection(damage - ProtectionFactor());
    }

    protected abstract double ProtectionFactor();
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

    protected override double ProtectionFactor()
    {
        return 0;
    }
}

public class MeshTshirt : ShieldProtection
{
    public MeshTshirt(ShieldProtection shield) : base(shield)
    { }

    protected sealed override double ProtectionFactor()
    {
        return 1;
    }
}

public class Vest : ShieldProtection
{
    public Vest(ShieldProtection shield) : base(shield)
    {
    }

    protected sealed override double ProtectionFactor()
    {
        return 7;
    }
}

public class ArmoredVest : ShieldProtection
{
    public ArmoredVest(ShieldProtection shield) : base(shield)
    {
    }

    protected sealed override double ProtectionFactor()
    {
        return 8;
    }
}