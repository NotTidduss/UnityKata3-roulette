using UnityEngine;

public class Bet : MonoBehaviour
{
    private Master mRef;

    void Start() => mRef = GameObject.Find("Master").GetComponent<Master>();

    public void placeBet(int amount, RouletteColor color) {
        mRef.setBet(amount);
        mRef.setBetColor(color);
        
        mRef.startSpin();
    } 
}
