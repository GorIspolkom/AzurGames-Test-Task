using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public abstract class Interactable : MonoBehaviour
{
    [Inject] protected InteractableMediator interactableMediator;
    [SerializeField] private ParticleSystem _particleSystem;
    [SerializeField] public double interactableCoast;

    public void Init(InteractableMediator interactableMediator)
    {
        this.interactableMediator = interactableMediator;
    }

    public abstract void Interact();
    public virtual IEnumerator ShowEffects()
    {
        gameObject.SetActive(false);
        _particleSystem.Play();
        yield return new WaitForSecondsRealtime(1f);
    }
}
