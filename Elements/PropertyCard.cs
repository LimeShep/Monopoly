using Monopoly.Core;

namespace Monopoly.Elements;

public class PropertyCard : GameCard {
    public int Id { get; private set; }
    public string Name { get; private set; }

    public Player? Owner { get; private set; }

    public decimal Price { get; private set; }
    public decimal Mortgage => Math.Round(Price / 2);
    public decimal HouseCost { get; private set; }
    public decimal HouseSellPrice => Math.Round(HouseCost / 2);

    public decimal[] RentPrices { get; private set; } = new decimal[6];

    public bool IsMortgaged => Level == LevelState.Mortgaged;
    public LevelState Level { get; private set; }
    public PropertyGroup PropertyGroup { get; private set; }

    public void ChangeOwner(Player plr) {
        if (Owner != null) {
            Owner.Wallet.Inventory.Remove(this);
        }
        Owner = plr;
        plr.Wallet.Inventory.Add(this);
        if (IsMortgaged && Settings.Instance.MortgageRepayOnTransfer) {
            // force mortgage repay;
        }
    }

    public void Purchase(Player plr) {
        if (plr.Wallet.Balance < Price) return;
        plr.Wallet.Balance -= Price;
        ChangeOwner(plr);
    }

    public void LevelUp() {
        if (Owner.Wallet.Balance < HouseCost) return;
        if (Level == LevelState.Hotel) return;
        // check if there are houses in the bank.
        Owner.Wallet.Balance -= HouseCost;
        Level++;
    }

    public void LevelDown() {
        if (Level == LevelState.Mortgaged) return;
        if (Level > LevelState.House) {
            Owner.Wallet.Balance += HouseSellPrice;
        } else {
            Owner.Wallet.Balance += Mortgage;
        }
        Level--;
    }

    public override void OnVisit(Player plr) {
        if (Owner == null) {
            if (plr.Wallet.Balance < Price) {
                // announce auction.
                return;
            }
            // ask for the decision
        }
    }
}