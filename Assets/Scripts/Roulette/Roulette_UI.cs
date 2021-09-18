using UnityEngine;
using UnityEngine.UI;

public class Roulette_UI : MonoBehaviour
{
    [Header("Scene References")]
    [SerializeField] private Roulette_Master master;

    [Header("Menu References")]
    [SerializeField] private GameObject betMenu;
    [SerializeField] private GameObject resultMenu;

    [Header("Text References")]
    [SerializeField] private Text chipsText;
    [SerializeField] private Text resultsText;

    public void initialize() {
        hideAllMenus();
        showBetMenu();
        updateChipsText();
    }

    #region Menu
    public void hideAllMenus() {
        betMenu.SetActive(false);
        resultMenu.SetActive(false);
    }
    public void showBetMenu() => betMenu.SetActive(true);
    public void showResultMenu() => resultMenu.SetActive(true);
    #endregion

    #region Text
    private void setText(Text t, string s) => t.text = s;
    public void setResultsText(string newText) => setText(resultsText, newText);
    public void updateChipsText() => setText(chipsText, "Chips: " + PlayerPrefs.GetInt("roulette_chips"));
    #endregion

    #region Button
    public void placeBet(int amount, Roulette_Color color) {
        master.setBet(amount);
        master.setBetColor(color);
        master.startSpin();
    } 
    #endregion
}
