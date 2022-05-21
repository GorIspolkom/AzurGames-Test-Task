public sealed class FinalPanel : InterfacePanel
{
    private LoadLevel nextLevel;

    public void InitPanel(LoadLevel loadLevel) { nextLevel = loadLevel; }

    public override void Open()
    {
        base.Open();
    }

    public void OpenNextLevel()
    {
        nextLevel();
    }
}
