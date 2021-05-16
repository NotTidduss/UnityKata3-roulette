using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void playAgain() => SceneManager.LoadScene("Main");
}
