using LR2.Factory;
using LR2.Games;

namespace LR2;

internal static class Program
{
    public static void Main(string[] args)
    {
        var tarik = DefaultFactory.CreateGameAccount("Tarik", "Default");
        var tarak = DefaultFactory.CreateGameAccount("Tarak", "Training");

        for (var i = 0; i < 10; i++)
        {
            var game = (i % 3) switch
            {
                0 => DefaultFactory.CreateGame("Default"),
                1 => DefaultFactory.CreateGame("Training"),
                _ => DefaultFactory.CreateGame("OneRatingPlayer")
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

        var streak = DefaultFactory.CreateGameAccount("Streak", "Streak");
        for (int i = 0; i < 5; i++)
        {
            var game = DefaultFactory.CreateGame("Default");
            streak.WinGame(game);
        }
        streak.GetStats();
    }
}