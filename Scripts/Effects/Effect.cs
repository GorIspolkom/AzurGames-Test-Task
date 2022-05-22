using UnityEngine;

public class Effect : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particleSystem;
    [SerializeField] private float _particlesTime;
    private GameObject _rootObject;

    public void Init(GameObject rootObj)
    {
        _rootObject = rootObj;
    }

    public virtual void EffectStart()
    {
        _particleSystem.Play();
    }

    protected void EffectLifeTime()
    {
        if (_particlesTime <= 0f)
            Destroy(_rootObject);
        _particlesTime -= Time.deltaTime;
    }
}
