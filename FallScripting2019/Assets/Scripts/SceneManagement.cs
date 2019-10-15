using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu]
public class SceneManagement : ScriptableObject
{
    public void LoadScene (string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
