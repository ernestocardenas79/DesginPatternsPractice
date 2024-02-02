namespace Players;

public class PlayerWithProtection {
    public static Player Mesh(Player player){
        return new PlayerLvl1WithMesh()
            {
                Life = player.Life,
                Name = player.Name
            };
    }

    public static Player Velt(Player player){
        return new PlayerLvl1WithVelt()
            {
                Life = player.Life,
                Name = player.Name
            };
    }

    public static Player MeshVelt(Player player){
        return new PlayerLvl1WithMeshVelt()
            {
                Life = player.Life,
                Name = player.Name
            };
    }
}