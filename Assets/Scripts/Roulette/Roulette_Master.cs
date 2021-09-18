using UnityEngine;

public class Roulette_Master : MonoBehaviour
{
    [Header("Scene Reference")]
    [SerializeField] private Roulette_UI ui;
    [SerializeField] private Roulette_Wheel wheel;

    private int currentChips;
    private int bet = 0;
    private Roulette_Color betColor;
    private Roulette_WheelNumber wheelNumber;
    
    void Start() {
        currentChips = PlayerPrefs.GetInt("roulette_chips");
        ui.initialize();
    }

    public void setBet(int newBet) => bet = newBet;    
    public void setBetColor(Roulette_Color newBetColor) => betColor = newBetColor;   
    public void setCurrentWheelNumber(Roulette_WheelNumber newWheelNumber) => wheelNumber = newWheelNumber;    

    public void startSpin() {
        ui.hideAllMenus();
        wheel.startSpinning();
    }

    public void finish() {
        ui.showResultMenu();

        if (betColor == wheelNumber.getColor()) {
            ui.setResultsText("YOU WON");
            currentChips += bet;
        }
        else {
            ui.setResultsText("YOU LOST");
            currentChips -= bet;
        }

        PlayerPrefs.SetInt("roulette_chips", currentChips);
        ui.updateChipsText();
    }
}
