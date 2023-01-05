using LR2.Factory;
using LR2.GameAccounts;
using LR2.Games;

namespace LR2;

internal static class Program
{
    public static void Main(string[] args)
    {
        var tarik = DefaultFactory.CreateGameAccount("Tarik", AccountType.Default);
        var tarak = DefaultFactory.CreateGameAccount("Tarak", AccountType.Training);

        for (var i = 0; i < 10; i++)
        {
            var game = (i % 3) switch
            {
                0 => DefaultFactory.CreateGame(GameType.Default),
                1 => DefaultFactory.CreateGame(GameType.Training),
                _ => DefaultFactory.CreateGame(GameType.OneRaiting)
            };
            if (i % 2 == 0)
            {
                tarik.WinGame(game);
                tarak.LoseGame(game);
            }
            else
            {
                tarak.WinGame(game);
                tarik.LoseGame(game);
            }
        }
        
        tarik.GetStats();
        tarak.GetStats();

        var streak = DefaultFactory.CreateGameAccount("Streak", AccountType.Streak);
        for (int i = 0; i < 5; i++)
        {
            var game = DefaultFactory.CreateGame(GameType.Default);
            streak.WinGame(game);
        }
        streak.GetStats();
    }
}