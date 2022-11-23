using LR2.Factory;
using LR2.Games;

namespace LR2.GameAccounts;

public class StreakGameAccount : GameAccount
{
    private const int StreakGamesCount = 3;

    private int _currentRating;

    public StreakGameAccount(string userName) : base(userName)
    {
        _currentRating = 1;
    }

    public override void WinGame(Game game)
    {
        GamesCount++;
        if (IsWinStreak())
            _currentRating += game.GetGameRating() * 2;
        else
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

    private bool IsWinStreak()
    {
        //Skipping all games except last STREAK_GAMES_COUNT 
        return GamesHistory.Skip(GamesHistory.Count - StreakGamesCount).All(result => result.IsWin);
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