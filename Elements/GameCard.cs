using Monopoly.Core;

namespace Monopoly.Elements;

public abstract class GameCard {
    public string QrId;
    public abstract void OnVisit(Player plr);
}