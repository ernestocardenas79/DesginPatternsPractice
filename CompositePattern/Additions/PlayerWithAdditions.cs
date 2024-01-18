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
    { }

    public override double CalculateProtection(double damage)
    {
        Console.WriteLine($"Mesh Protection: {1}, Input Damage: {damage} Total Damage: {damage - 1}\n");

        return damage - 1;
    }
}

public class Vest : ShieldProtection
{
    public Vest(ShieldProtection shield) : base(shield)
    {
    }

    public override double CalculateProtection(double damage)
    {
        Console.WriteLine($"Vest Protection: {7}, Input Damage: {damage} Total Damage: {damage - 7}\n");

        return Shield.CalculateProtection(damage - 7);
    }
}

public class ArmoredVest : ShieldProtection
{
    public ArmoredVest(ShieldProtection shield) : base(shield)
    {
    }
    public override double CalculateProtection(double damage)
    {
        Console.WriteLine($"ArmoredVest Protection: {8}, Input Damage: {damage} Total Damage: {damage - 8}\n");

        return Shield.CalculateProtection(damage - 8);
    }
}