public class PlayerData
{
    public double CoinsCount { get; private set; }

    public PlayerData(double coinsCount)
    {
        CoinsCount = coinsCount;
    }

    public PlayerData()
    {
        CoinsCount = 0;
    }

    public void AddCoins(double coinsCount) => CoinsCount += coinsCount;
}
