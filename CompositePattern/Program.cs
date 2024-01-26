using Players;

Console.Clear();

Player player1 = new PlayerLvl1() { Name = "player 1" };
Player player2 = new PlayerLvl1() { Name = "player 2" };

Console.WriteLine($"Player 2 is walking on the street with {player2.Life} of life\n");


player1.Attack(player2); 

player2 = PlayerWithProtection.WithVeltBaseOn(player2);

Console.WriteLine($"Player 2 wears a Velt with {player2.Life} of life\n");

player1.Attack(player2);

player2 = PlayerWithProtection.WithMeshVeltBaseOn(player2);

Console.WriteLine($"Player 2 wears a Mesh under a Velt with {player2.Life} of life\n");

player1.Attack(player2);


Console.WriteLine("Statistics==========");
Console.WriteLine("====================");

Console.WriteLine($"Player1: {player1.Life}");
Console.WriteLine($"      Weapon    : {player1.Weapon}");

Console.WriteLine($"Player2: {player2.Life}");
Console.WriteLine($"      Weapon    : {player2.Weapon}");
Console.WriteLine("====================\n\n");

