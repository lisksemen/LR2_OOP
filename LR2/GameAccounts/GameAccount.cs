using LR2.Games;

namespace LR2.GameAccounts;

public abstract class GameAccount
{
    protected List<GameResult> GamesHistory;

    protected GameAccount(string userName)
    {
        UserName = userName;
        GamesCount = 0;
        GamesHistory = new List<GameResult>();
    }

    public string UserName { get; }

    public int GamesCount { get; set; }

    public abstract void WinGame(Game game);
    public abstract void LoseGame(Game game);

    public abstract void GetStats();
}