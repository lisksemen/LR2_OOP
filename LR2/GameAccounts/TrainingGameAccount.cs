using LR2.Factory;
using LR2.Games;

namespace LR2.GameAccounts;

public class TrainingGameAccount : GameAccount
{
    private const int StreakGamesCount = 3;

    public TrainingGameAccount(string userName) : base(userName)
    {
    }

    public override void WinGame(Game game)
    {
        GamesCount++;
        GamesHistory.Add(DefaultFactory.CreateGameResult(game, GameResult.GameResultType.Win));
    }

    public override void LoseGame(Game game)
    {
        GamesCount++;
        GamesHistory.Add(DefaultFactory.CreateGameResult(game, GameResult.GameResultType.Lose));
    }

    public override void GetStats()
    {
        Console.WriteLine("Stats for: " + UserName);
        Console.WriteLine("CurrentRating" + ": " + 0 + " (Training Account)");
        Console.WriteLine(nameof(GamesCount) + ": " + GamesCount);
        Console.WriteLine("\nGames history:");
        GamesHistory.ForEach(Console.WriteLine);
    }
}