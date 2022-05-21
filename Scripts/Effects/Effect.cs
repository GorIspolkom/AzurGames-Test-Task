using UnityEngine;

public class Effect : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particleSystem;
    [SerializeField] private float _particlesTime;

    protected virtual void EffectStart()
    {
        _particleSystem.Play();
    }

    protected void EffectLifeTime()
    {
        if (_particlesTime < 0f)
            Destroy(gameObject);
        _particlesTime -= Time.deltaTime;
    }
}
