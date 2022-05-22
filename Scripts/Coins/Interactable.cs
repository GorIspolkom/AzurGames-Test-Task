using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    [SerializeField] public double interactableCoast;
    [SerializeField] protected GameObject coinModel;
    [SerializeField] protected Effect effect;

    protected InteractableMediator interactableMediator;

    public void Init(InteractableMediator interactableMediator)
    {
        this.interactableMediator = interactableMediator;
        effect.Init(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
            Interact();
    }

    public abstract void Interact();
}
