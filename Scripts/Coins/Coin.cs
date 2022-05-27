using UnityEngine;

public sealed class Coin : Collectable
{
    [SerializeField] private float _rotationVelocity;

    public override void Interact()
    {
        collectableMediator.Notify(this);
        effect.EffectStart();
        Destroy(coinModel);
    }

    private void Update()
    {
        RotateCoin();
    }

    private void RotateCoin() =>
       transform.RotateAround(transform.position,
           Vector3.up, _rotationVelocity * Time.deltaTime);
}
