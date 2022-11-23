namespace LR2.Games;

public class OneRatingPlayerGame : Game
{
    public override string GetGameType()
    {
        return "OneRatingPlayer";
    }

    public override int GetGameRating()
    {
        return 1;
    }
}