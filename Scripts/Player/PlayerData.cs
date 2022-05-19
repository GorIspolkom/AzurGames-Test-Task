public class PlayerData
{
    public double CoinsCount { get; private set; }

    public PlayerData(double coinsCount = 0)
    {
        CoinsCount = coinsCount;
    }

    public void AddCoins(double coinsCount) => CoinsCount += coinsCount;
}
