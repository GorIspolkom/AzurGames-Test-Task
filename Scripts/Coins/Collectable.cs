using UnityEngine;

public abstract class Collectable : MonoBehaviour
{
    [SerializeField] protected double collectableCoast;
    [SerializeField] protected GameObject coinModel;
    [SerializeField] protected Effect effect;

    protected CollectableMediator collectableMediator;

    public double CollectableCoast { get { return collectableCoast; } }

    private Transform _targetTransform;

    public void Init(CollectableMediator collectableMediator, EffectPool effectPool, Transform targetTransform)
    {
        _targetTransform = targetTransform;
        this.collectableMediator = collectableMediator;
       
        effect.Init(gameObject, effectPool);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.Equals(_targetTransform))
            Interact();
    }

    public abstract void Interact();
}
