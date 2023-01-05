namespace LR2.Games;

public abstract class Game
{
    private static int CurrentId = 0;

    protected readonly int Id;
    public abstract int GetId();
    public abstract GameType GetGameType();

    public abstract int GetGameRating();

    protected Game()
    {
        Id = CurrentId++;
    }

    public override string ToString()
    {
        return "Game:{GameType: " + GetGameType() + ", GameRating: " + GetGameRating() + ", ID: " + GetId() + "}";
    }
}