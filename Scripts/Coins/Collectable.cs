using UnityEngine;

public abstract class Collectable : MonoBehaviour
{
    [SerializeField] protected double collectableCoast;
    [SerializeField] protected GameObject coinModel;
    [SerializeField] protected Effect effect;

    protected CollectableMediator collectableMediator;

    public double CollectableCoast { get { return collectableCoast; } }

    public void Init(CollectableMediator collectableMediator, EffectPool effectPool)
    {
        this.collectableMediator = collectableMediator;
        effect.Init(gameObject, effectPool);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Player>(out Player player))
            Interact();
    }

    public abstract void Interact();
}
