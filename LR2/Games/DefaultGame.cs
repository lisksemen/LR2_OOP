namespace LR2.Games;

public class DefaultGame : Game
{
    public override GameType GetGameType()
    {
        return GameType.Default;
    }

    public override int GetGameRating()
    {
        return 1;
    }
}