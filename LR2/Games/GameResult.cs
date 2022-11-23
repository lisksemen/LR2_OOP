namespace LR2.Games;

public class GameResult
{
    private readonly Game GameParams;

    public GameResult(Game gameParams, bool isWin)
    {
        GameParams = gameParams;
        IsWin = isWin;
    }

    public bool IsWin { get; }

    public string GetGameType()
    {
        return GameParams.GetGameType();
    }

    public int GetGameRating()
    {
        return GameParams.GetGameRating();
    }

    public override string ToString()
    {
        return GameParams + ", " + nameof(IsWin) + ": " + IsWin;
    }
}