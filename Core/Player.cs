namespace Monopoly.Core;

public class Player {
    public Wallet Wallet { get; }
    public Player() {
        Wallet = new(this);
    }
}