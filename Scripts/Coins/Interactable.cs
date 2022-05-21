using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    protected InteractableMediator interactableMediator;
    [SerializeField] public double interactableCoast;

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
