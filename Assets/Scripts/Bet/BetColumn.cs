using UnityEngine;

public class BetColumn : MonoBehaviour
{
    public RouletteColor betColor;
    public Bet bsRef;

    public void bet(int amount) => bsRef.placeBet(amount, betColor);
    public void betAll() => bet(GameObject.Find("Master").GetComponent<Master>().getCurrentChips());
}
