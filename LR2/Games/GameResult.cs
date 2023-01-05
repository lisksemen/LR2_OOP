namespace LR2.Games;

public class GameResult
{
    public enum GameResultType
    {
        Win,
        Lose
    }
    private readonly Game GameParams;

    public GameResult(Game gameParams, GameResultType gameResultType)
    {
        GameParams = gameParams;
        IsWin = gameResultType;
    }

    public GameResultType IsWin { get; }

    public GameType GetGameType()
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