namespace Monopoly.Core;

public class Player {
    public Wallet Wallet { get; } = new(this);
}