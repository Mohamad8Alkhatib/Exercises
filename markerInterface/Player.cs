class Player : ISaveable
{
    public string Name { set; get; }
    public int Level { get; set; }
    public Player(string name, int level)
    {
        this.Name = name;
        this.Level = level;
    }
}