namespace LR2.Games;

public class TrainingGame : Game
{
    public override GameType GetGameType()
    {
        return GameType.Training;
    }

    public override int GetGameRating()
    {
        return 0;
    }

    public TrainingGame() : base() { }

    public override int GetId()
    {
        return Id;
    }
}