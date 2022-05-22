using UnityEngine;

public sealed class Coin : Interactable
{
    [SerializeField] private float _rotationVelocity;

    public override void Interact()
    {
        interactableMediator.Notify(this);
        effect.EffectStart();
        Destroy(coinModel);
    }

    private void Update()
    {
        RotateCoin();
    }

    private void RotateCoin() =>
       transform.RotateAround(transform.position,
           Vector3.left, _rotationVelocity * Time.deltaTime);
}
