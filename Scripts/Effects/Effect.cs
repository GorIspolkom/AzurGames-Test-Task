using UnityEngine;

public class Effect : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particleSystem;
    [SerializeField] private float _particlesTime;
    private GameObject _rootObject;
    private EffectPool _effectPool;

    public GameObject RootObject { get { return _rootObject; } }

    public void Init(GameObject rootObj, EffectPool effectPool)
    {
        _rootObject = rootObj;
        _effectPool = effectPool;
    }

    public virtual void EffectStart()
    {
        _particleSystem.Play();
    }

    protected void EffectLifeTime()
    {
        if (_particlesTime <= 0f)
            _effectPool.Notify(this);
        _particlesTime -= Time.deltaTime;
    }
}
