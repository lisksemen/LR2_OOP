namespace LR2.Games;

public class OneRatingPlayerGame : Game
{
    public override GameType GetGameType()
    {
        return GameType.OneRaiting;
    }

    public override int GetGameRating()
    {
        return 1;
    }
}