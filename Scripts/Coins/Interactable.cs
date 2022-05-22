using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    [SerializeField] public double interactableCoast;
    protected InteractableMediator interactableMediator;

    public void Init(InteractableMediator interactableMediator)
    {
        this.interactableMediator = interactableMediator;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
            Interact();
    }

    public abstract void Interact();
}
