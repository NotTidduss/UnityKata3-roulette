using UnityEngine;
using UnityEngine.SceneManagement;

public class Roulette_Init : MonoBehaviour
{
    void Awake() {
        initializePlayerPrefs();
        SceneManager.LoadScene("1_Roulette");
    }

    private void initializePlayerPrefs(){
        // INT roulette_chips - the amount of chips the player currently has, start value: 100
        if (PlayerPrefs.GetInt("roulette_chips") < 1) PlayerPrefs.SetInt("roulette_chips", 100);
    }
}
