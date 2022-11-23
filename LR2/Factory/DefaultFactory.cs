using LR2.GameAccounts;
using LR2.Games;

namespace LR2.Factory;

public static class DefaultFactory
{
    public static Game CreateGame(string type)
    {
        return type switch
        {
            "Default" => new DefaultGame(),
            "Training" => new TrainingGame(),
            "OneRatingPlayer" => new OneRatingPlayerGame(),
            _ => throw new ArgumentException()
        };
    }

    public static GameResult CreateGameResult(Game game, bool isWin)
    {
        return new GameResult(game, isWin);
    }

    public static GameAccount CreateGameAccount(string userName, string type)
    {
        return type switch
        {
            "Default" => new DefaultGameAccount(userName),
            "Streak" => new StreakGameAccount(userName),
            "Training" => new TrainingGameAccount(userName),
            _ => throw new ArgumentException()
        };
    }
}