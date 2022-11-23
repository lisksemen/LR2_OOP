namespace LR2.Games;

public abstract class Game
{
    public abstract string GetGameType();

    public abstract int GetGameRating();

    public override string ToString()
    {
        return "Game:{GameType: " + GetGameType() + ", GameRating: " + GetGameRating() + "}";
    }
}