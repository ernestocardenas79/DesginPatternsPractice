namespace Players;

public class PlayerWithProtection {
    public static Player WithVeltBaseOn(Player player){
        return new PlayerLvl1WithVelt()
            {
                Life = player.Life,
                Name = player.Name
            };
    }

    public static Player WithVeltMeshBaseOn(Player player){
        return new PlayerLvl1WithMesh()
            {
                Life = player.Life,
                Name = player.Name
            };
    }
    public static Player WithMeshVeltBaseOn(Player player){
        return new PlayerLvl1WithMeshVelt()
            {
                Life = player.Life,
                Name = player.Name
            };
    }
}