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


// ShieldProtection player1ArmoredVelt = new ArmoredVest(player1Mesh);
// player1.Attack(player1ArmoredVelt);


Console.WriteLine("Statistics==========");
Console.WriteLine("====================");

Console.WriteLine($"Player1: {player1.life}");
Console.WriteLine($"      Weapon    : {player1.Weapon}");
// Console.WriteLine($"      Additaments: {player1.life}");

Console.WriteLine($"Player2: {player2.life}");
Console.WriteLine($"      Weapon    : {player2.Weapon}");
// Console.WriteLine($"      Additaments: {player1.life}");
Console.WriteLine("====================\n\n");

