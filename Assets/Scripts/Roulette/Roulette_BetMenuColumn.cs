using UnityEngine;

public class Roulette_BetMenuColumn : MonoBehaviour
{
    [Header("Scene References")]
    [SerializeField] private Roulette_UI ui;

    [Header("Column Properties")]
    [SerializeField] private Roulette_Color betColor;

    public void bet(int amount) => ui.placeBet(amount, betColor);
    public void betAll() => bet(PlayerPrefs.GetInt("roulette_chips"));
}
