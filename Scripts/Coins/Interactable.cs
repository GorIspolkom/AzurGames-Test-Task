using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    [SerializeField] protected double interactableCoast;
    [SerializeField] protected GameObject coinModel;
    [SerializeField] protected Effect effect;

    protected InteractableMediator interactableMediator;

    public double InteractableCoast { get { return interactableCoast; } }

    public void Init(InteractableMediator interactableMediator)
    {
        this.interactableMediator = interactableMediator;
        effect.Init(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals(Settings.PlayerTag))
            Interact();
    }

    public abstract void Interact();
}
