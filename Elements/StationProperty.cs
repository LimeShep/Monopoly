namespace Monopoly.Elements;

public class StationProperty : PropertyCard {
    public override bool Levelable { get; protected set; } = false;
    public static StationProperty Create(string name, string qrId, PropertyGroup group, decimal price, decimal[] rentPrices) {
        return Create<StationProperty>(name, qrId, group, price, rentPrices);
    }
    public override decimal GetRent() {
        if (Level == LevelState.Mortgaged) return 0;
        if (Owner == null) return 0;
        var count = Owner.Wallet.Inventory.Count(p => p is StationProperty && p.Level != LevelState.Mortgaged);
        return RentPrices[count - 1];
    }
}