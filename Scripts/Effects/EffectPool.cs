using UnityEngine;
using System;

public sealed class EffectPool
{
    public Action<Effect> EffectEnd;

    public EffectPool()
    {
        EffectEnd += Notify;
        EffectEnd += InfoData;
    }

    private void Notify(Effect effect)
    {
        UnityEngine.Object.Destroy(effect.RootObject);   
    }

    private void InfoData(Effect effect)
    {
        Debug.Log("Effect" + effect.name + "end");
    }
}
