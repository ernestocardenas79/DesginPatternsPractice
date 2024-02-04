using System.Globalization;
using Players;
using Players.Shields;

Console.Clear();

Player player1 = new PlayerLvl1() { Name = "player 1" };
Player player2 = new PlayerLvl1() { Name = "player 2" };

Console.WriteLine($"Player 2 is walking on the street with {player2.life} of life\n");


player1.Attack(player2);

ShieldProtection meshTshirt = new MeshTshirt(player2.Shield);
player2.Shield = meshTshirt;

Console.WriteLine($"Player 2 wears a MeshTshirt with {player2.life} of life\n");

player1.Attack(player2);


ShieldProtection MeshUnderVelt = new Vest(player2.Shield);
player2.Shield = MeshUnderVelt;
Console.WriteLine($"Player 2 wears a MeshUnderVelt with {player2.life} of life\n");

player1.Attack(player2);

ShieldProtection VestUnderPlasmaShield = new Vest(player1.Shield);
player1.Shield = VestUnderPlasmaShield;

player2.Attack(player1);