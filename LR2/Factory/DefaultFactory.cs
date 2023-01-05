using LR2.GameAccounts;
using LR2.Games;

namespace LR2.Factory;

public static class DefaultFactory
{
    public static Game CreateGame(GameType type)
    {
        return type switch
        {
            GameType.Default => new DefaultGame(),
            GameType.Training => new TrainingGame(),
            GameType.OneRaiting => new OneRatingPlayerGame(),
            _ => throw new ArgumentException()
        };
    }

    public static GameResult CreateGameResult(Game game, bool isWin)
    {
        return new GameResult(game, isWin);
    }

    public static GameAccount CreateGameAccount(string userName, AccountType type)
    {
        return type switch
        {
            AccountType.Default => new DefaultGameAccount(userName),
            AccountType.Streak => new StreakGameAccount(userName),
            AccountType.Training => new TrainingGameAccount(userName),
            _ => throw new ArgumentException()
        };
    }
}