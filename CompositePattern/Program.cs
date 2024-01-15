using Players;
using Players.Additions;

Player player1 = new PlayerLvl1();
Player player2 = new PlayerLvl1();


player1.Attack(player2);
PlayerWithAdditions player1Mesh = new MeshTshirt(player2);

player1.Attack(player1Mesh);
player1.Attack(player1Mesh);

Console.WriteLine("Statistics==========");
Console.WriteLine("====================");

Console.WriteLine($"Player1: {player1.life}");
Console.WriteLine($"      Weapon    : {player1.Weapon}");
// Console.WriteLine($"      Additaments: {player1.life}");

Console.WriteLine($"Player2: {player1Mesh.life}");
Console.WriteLine($"      Weapon    : {player1Mesh.Weapon}");
// Console.WriteLine($"      Additaments: {player1.life}");
Console.WriteLine("====================\n\n");

