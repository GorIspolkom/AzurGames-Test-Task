using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class Coin : Interactable
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
            Interact();
    }
    public override void Interact()
    {
        interactableMediator.Notify(this);
        StartCoroutine(ShowEffects());
        Destroy(gameObject);
    }

    private void RotateCoin()
    {
        transform.RotateAround(transform.position, Vector3.left, 30 * Time.deltaTime);
    }

    private void Update()
    {
        RotateCoin();
    }
}
