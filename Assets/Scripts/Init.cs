using UnityEngine;
using UnityEngine.SceneManagement;

public class Init : MonoBehaviour
{
    void Awake() {
        initializePlayerPrefs();
        SceneManager.LoadScene("Main");
    }

    private void initializePlayerPrefs(){
        PlayerPrefs.DeleteAll();

        // kata3_chips - basically score here, default 100
        PlayerPrefs.SetInt("kata3_chips", 100);
    }
}
