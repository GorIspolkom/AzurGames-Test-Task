using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public abstract class Interactable : MonoBehaviour
{
    [Inject] protected InteractableMediator interactableMediator;
    protected EffectsSpawner effectsSpawner;
    [SerializeField] public double interactableCoast;

    public void Init(InteractableMediator interactableMediator, EffectsSpawner effectsSpawner)
    {
        this.interactableMediator = interactableMediator;
        this.effectsSpawner = effectsSpawner;
    }

    public abstract void Interact();

    public virtual IEnumerator ShowEffects()
    {
        gameObject.SetActive(false);
        effectsSpawner.SpawnParticle(transform.position);
        yield return new WaitForSecondsRealtime(1f);
    }
}
