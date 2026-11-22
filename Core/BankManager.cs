namespace Monopoly.Core;

public class BankManager() {
    public static BankManager Instance;
    public List<PropertyCard> AllCards = [];
    public void InitProperties() {
        AllCards.Add(PropertyCard.Create("Ulica Konopacka", "PR BROWN1", PropertyGroup.Brown, 60, [2, 10, 30, 90, 160, 250]));
        AllCards.Add(PropertyCard.Create("Ulica Stalowa", "PR BROWN2", PropertyGroup.Brown, 60, [4, 20, 60, 180, 320, 450]));

        AllCards.Add(PropertyCard.Create("Ulica Radzymińska", "PR MINT1", PropertyGroup.Mint, 100, [6, 30, 90, 270, 400, 550]));
        AllCards.Add(PropertyCard.Create("Ulica Jagiellońska", "PR MINT2", PropertyGroup.Mint, 100, [6, 30, 90, 270, 400, 550]));
        AllCards.Add(PropertyCard.Create("Ulica Targowa", "PR MINT3", PropertyGroup.Mint, 120, [8, 40, 100, 300, 450, 600]));

        AllCards.Add(PropertyCard.Create("Ulica Płowiecka", "PR PINK1", PropertyGroup.Pink, 140, [10, 50, 150, 450, 625, 750]));
        AllCards.Add(PropertyCard.Create("Ulica Marsa", "PR PINK2", PropertyGroup.Pink, 140, [10, 50, 150, 450, 625, 750]));
        AllCards.Add(PropertyCard.Create("Ulica Grochowska", "PR PINK3", PropertyGroup.Pink, 160, [12, 60, 180, 500, 700, 900]));

        AllCards.Add(PropertyCard.Create("Ulica Obozowa", "PR ORANGE1", PropertyGroup.Orange, 180, [14, 70, 200, 550, 750, 950]));
        AllCards.Add(PropertyCard.Create("Ulica Górczewska", "PR ORANGE2", PropertyGroup.Orange, 180, [14, 70, 200, 550, 750, 950]));
        AllCards.Add(PropertyCard.Create("Ulica Wolska", "PR ORANGE3", PropertyGroup.Orange, 200, [16, 80, 220, 600, 800, 1_000]));

        AllCards.Add(PropertyCard.Create("Ulica Mickiewicza", "PR RED1", PropertyGroup.Red, 220, [18, 90, 250, 700, 875, 1_050]));
        AllCards.Add(PropertyCard.Create("Ulica Słowackiego", "PR RED2", PropertyGroup.Red, 220, [18, 90, 250, 700, 875, 1_050]));
        AllCards.Add(PropertyCard.Create("Plac Wilsona", "PR RED3", PropertyGroup.Red, 240, [20, 100, 300, 750, 925, 1_100]));

        AllCards.Add(PropertyCard.Create("Ulica Świętokrzyska", "PR YELLOW1", PropertyGroup.Yellow, 260, [22, 110, 330, 800, 975, 1_150]));
        AllCards.Add(PropertyCard.Create("Krakowskie Przedmieście", "PR YELLOW2", PropertyGroup.Yellow, 260, [22, 110, 330, 800, 975, 1_150]));
        AllCards.Add(PropertyCard.Create("Nowy Świat", "PR YELLOW3", PropertyGroup.Yellow, 280, [24, 120, 360, 850, 1_100, 1_200]));

        AllCards.Add(PropertyCard.Create("Plac Trzech Krzyży", "PR GREEN1", PropertyGroup.Green, 300, [26, 130, 390, 900, 1_100, 1_275]));
        AllCards.Add(PropertyCard.Create("Ulica Marszałkowska", "PR GREEN2", PropertyGroup.Green, 300, [26, 130, 390, 900, 1_100, 1_275]));
        AllCards.Add(PropertyCard.Create("Aleje Jerozolimskie", "PR GREEN3", PropertyGroup.Green, 320, [28, 150, 450, 1_000, 1_200, 1_400]));

        AllCards.Add(PropertyCard.Create("Ulica Belwederska", "PR BLUE1", PropertyGroup.Blue, 350, [35, 175, 500, 1_100, 1_300, 1_500]));
        AllCards.Add(PropertyCard.Create("Aleje Ujazdowskie", "PR BLUE2", PropertyGroup.Blue, 400, [40, 200, 600, 1_400, 1_700, 2_000]));

        AllCards.Add(StationProperty.Create("Dworzec Zachodni", "PR BLACK1", PropertyGroup.Black, 200, [25, 50, 100, 200]));
        AllCards.Add(StationProperty.Create("Dworzec Gdański", "PR BLACK2", PropertyGroup.Black, 200, [25, 50, 100, 200]));
        AllCards.Add(StationProperty.Create("Dworzec Wschodni", "PR BLACK3", PropertyGroup.Black, 200, [25, 50, 100, 200]));
        AllCards.Add(StationProperty.Create("Dworzec Centralny", "PR BLACK4", PropertyGroup.Black, 200, [25, 50, 100, 200]));

        AllCards.Add(UtilityProperty.Create("Elektrownia", "PR WHITE1", PropertyGroup.White, 150, []));
        AllCards.Add(UtilityProperty.Create("Wodociągi", "PR WHITE2", PropertyGroup.White, 150, []));
    }
}