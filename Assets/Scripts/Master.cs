using UnityEngine;

public class Master : MonoBehaviour
{
    public GameObject betScreen;
    public Wheel wheel;
    public GameObject resultScreen;
    public TextUpdater tu;
    public float spinSpeed = 1.5f;

    private int currentChips;
    private int bet = 0;
    private RouletteColor betColor;
    private RouletteColor rouletteColor;
    
    void Start(){
        betScreen.SetActive(true);
        resultScreen.SetActive(false);
        currentChips = PlayerPrefs.GetInt("kata3_chips");

        tu.updateChipsText("Chips: " + currentChips);
    }

    public int getCurrentChips() => currentChips;
    public void setCurrentChips(int newCC) => currentChips = newCC;

    public int getBet() => bet;
    public void setBet(int newBet) => bet = newBet;    

    public RouletteColor getBetColor() => betColor;
    public void setBetColor(RouletteColor newBetColor) => betColor = newBetColor;   

    public RouletteColor getRouletteNumber() => rouletteColor;
    public void setRouletteNumber(RouletteColor newRouletteNumber) => rouletteColor = newRouletteNumber;    

    public void startSpin() {
        betScreen.SetActive(false);
        wheel.startSpinning(spinSpeed);
    }

    public void finish() {
        resultScreen.SetActive(true);

        if (betColor == rouletteColor) {
            tu.updateResultsText("YOU WON");

            currentChips += bet;
            PlayerPrefs.SetInt("kata3_chips", currentChips);
            tu.updateChipsText("Chips: " + currentChips);
        }
        else {
            tu.updateResultsText("YOU LOST");

            currentChips -= bet;
            PlayerPrefs.SetInt("kata3_chips", currentChips);
            tu.updateChipsText("Chips: " + currentChips);
        }
    }
}
