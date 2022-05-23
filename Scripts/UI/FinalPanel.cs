using DG.Tweening;
using UnityEngine;

public sealed class FinalPanel : InterfacePanel
{
    private LevelLoader _levelLoader;
    [SerializeField] private float _animationVelocity;

    public void InitPanel(LevelLoader levelLoader) 
    {
        _levelLoader = levelLoader;
        DOTween.Init();
    }

    public override void Open()
    {
        base.Open();
        (transform as RectTransform).DOScale(Vector3.one, _animationVelocity);
    }

    public void OpenNextLevel()
    {
        _levelLoader.OpenNextLevel();
    }
}
