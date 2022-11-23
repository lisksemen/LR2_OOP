namespace LR2.Games;

public class DefaultGame : Game
{
    public override string GetGameType()
    {
        return "Default";
    }

    public override int GetGameRating()
    {
        return 1;
    }
}