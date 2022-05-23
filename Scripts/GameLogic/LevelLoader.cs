using UnityEngine.SceneManagement;

public sealed class LevelLoader
{
    public void OpenNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
