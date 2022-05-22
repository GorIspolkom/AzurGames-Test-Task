using DG.Tweening;
using UnityEngine;

public sealed class FinalPanel : InterfacePanel
{
    private LevelManager _levelManager;
    [SerializeField] private float _animationVelocity;

    public void InitPanel(LevelManager levelManager) 
    {
        _levelManager = levelManager;
        DOTween.Init();
    }

    public override void Open()
    {
        base.Open();
        (transform as RectTransform).DOScale(Vector3.one, _animationVelocity);
    }

    public void OpenNextLevel()
    {
        _levelManager.OpenNextLevel();
    }
}
