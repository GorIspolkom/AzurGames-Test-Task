public sealed class CoinEffect : Effect
{ 
    private void Start()
    {
        EffectStart();
    }

    private void Update()
    {
        EffectLifeTime();
    }
}
