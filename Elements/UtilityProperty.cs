namespace Monopoly.Elements;

public class UtilityProperty : PropertyCard {
    public override bool Levelable { get; protected set; } = false;
    public static UtilityProperty Create(string name, string qrId, PropertyGroup group, decimal price, decimal[] rentPrices) {
        return Create<UtilityProperty>(name, qrId, group, price, rentPrices);
    }
    public override decimal GetRent() {
        if (Level == LevelState.Mortgaged) return 0;
        if (Owner == null) return 0;
        var multiplier = Owner.Wallet.Inventory.Count(p => p is UtilityProperty && p.Level != LevelState.Mortgaged);
        // ask for dice roll
        var roll = 12;
        return multiplier * 12;
    }
}