public sealed class CoinEffect : Effect
{
    public override void EffectStart()
    {
        gameObject.SetActive(true);
        base.EffectStart();
    }

    private void Update()
    {
        EffectLifeTime();
    }
}
