using UnityEngine;

public sealed class EffectPool
{
    public void Notify(Effect effect)
    {
        Object.Destroy(effect.RootObject);   
    }
}
