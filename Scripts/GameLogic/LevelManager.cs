using UnityEngine.SceneManagement;

public delegate void LoadLevel();

public sealed class LevelManager
{
    public void OpenNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
