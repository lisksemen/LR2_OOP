using LR2.Factory;
using LR2.Games;

namespace LR2.GameAccounts;

public class DefaultGameAccount : GameAccount
{
    private const int StreakGamesCount = 3;

    private int _currentRating;

    public DefaultGameAccount(string userName) : base(userName)
    {
        _currentRating = 1;
    }

    public override void WinGame(Game game)
    {
        GamesCount++;
        _currentRating += game.GetGameRating();
        GamesHistory.Add(DefaultFactory.CreateGameResult(game, true));
    }

    public override void LoseGame(Game game)
    {
        GamesCount++;
        GamesHistory.Add(DefaultFactory.CreateGameResult(game, false));
        if (game.GetGameType().Equals("OneRatingPlayer"))
            return;
        _currentRating -= game.GetGameRating();
    }

    public override void GetStats()
    {
        Console.WriteLine("Stats for: " + UserName);
        Console.WriteLine("CurrentRating" + ": " + _currentRating);
        Console.WriteLine(nameof(GamesCount) + ": " + GamesCount);
        Console.WriteLine("\nGames history:");
        GamesHistory.ForEach(Console.WriteLine);
    }
}