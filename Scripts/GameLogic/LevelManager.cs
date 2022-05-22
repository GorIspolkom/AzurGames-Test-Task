using UnityEngine.SceneManagement;

public sealed class LevelManager
{
    public void OpenNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
