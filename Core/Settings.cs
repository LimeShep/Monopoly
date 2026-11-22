namespace Monopoly.Core;

public class Settings {
    public static Settings Instance;
    // If on, all taxes go to a special pile and the first parking arrival wins it.
    public bool ParkingJackpot = false;
    // If on, each player gets a random color set.
    public bool StartingCouples = false;
    // If on, you can build houses if you have at least two cards of a color set.
    public bool PrivateBuilding = false;
    // If on, you need to auction off the property you didn't buy.
    public bool AuctionOnDenial = true;
    // If on, the game ends immediately when the first player goes bankrupt.
    public bool FastFinish = false;
    // If on, forces the new property owner to unmortgage the property.
    public bool MortgageRepayOnTransfer = true;
}