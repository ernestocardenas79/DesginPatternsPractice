using System.Globalization;
using Weapons;

namespace Players.Shields;

public abstract class ShieldProtection
{
    protected ShieldProtection Shield { get; init; }
    protected int Protection {get; init;}
    private readonly string Name;
    public ShieldProtection(string name)
    {
        Name=name;
     }
    public ShieldProtection(string name, ShieldProtection shield)
    {
        Shield = shield;
        Name=name;
    }
    internal virtual double CalculateProtection(double damage)
    {
        PrintProtection(damage);
        return Shield.CalculateProtection(damage - Protection);
    }

    protected void PrintProtection(double damage)
    {
        Console.WriteLine($"{Name} Protection: {Protection}, Input Damage: {damage} Total Damage: {damage - Protection}\n");
    }
}

public class NoShield : ShieldProtection
{
    public NoShield():base("NoShield")
    {
    }
    internal sealed override double CalculateProtection(double damage)
    {
        return damage;
    }
}

public class MeshTshirt : ShieldProtection
{
    public MeshTshirt(ShieldProtection shield) : base("Mesh",shield)
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
    public Vest(ShieldProtection shield) : base("Vest",shield)
    {
        Protection =3;
    }
}