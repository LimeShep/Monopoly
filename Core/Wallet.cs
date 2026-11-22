using Monopoly.Elements;

namespace Monopoly.Core;

public class Wallet(Player plr) {
    public Player Player { get; private set; } = plr;
    public decimal Balance;
    public List<PropertyCard> Inventory { get; } = [];
}