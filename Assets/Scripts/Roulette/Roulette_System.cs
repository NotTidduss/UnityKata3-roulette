using UnityEngine;
using UnityEngine.SceneManagement;

public class Roulette_System : MonoBehaviour
{
    [Header("Scene Settings")]
    [SerializeField] private string rouletteSceneName = "1_Roulette";

    public void reloadRouletteScene() => SceneManager.LoadScene(rouletteSceneName);
}

public enum Roulette_Color {
    RED,
    BLACK,
    GREEN
}
