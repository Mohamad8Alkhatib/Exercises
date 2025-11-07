class GameSettings : ISaveable
{
    public bool IsSoundOn { set; get; }
    public int Difficulty { set; get; }
    public GameSettings(bool isSoundOn, int difficulty)
    {
        this.IsSoundOn = isSoundOn;
        this.Difficulty = difficulty;
    }
}