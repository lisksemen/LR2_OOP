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


    public OneRatingPlayerGame() : base() { }

    public override int GetId()
    {
        return Id;
    }
}