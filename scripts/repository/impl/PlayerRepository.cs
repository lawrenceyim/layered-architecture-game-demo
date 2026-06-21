public class PlayerRepository : IRepository {
    public int Money { get; set; }
    public int Health { get; set; }
    public int MaxHealth { get; set; }
    public int Mana { get; set; }
    public int MaxMana { get; set; }

    public void Save(string fileName) { }
    public void Load(string fileName) { }
}