using UnityEngine;

public class Roulette_WheelNumber : MonoBehaviour
{
    [Header("Scene References")]
    [SerializeField] private Roulette_Master master;

    [Header("WheelNumber Properties")]
    [SerializeField] private int number;
    [SerializeField] private Roulette_Color color;


    public int getNumber() => number;
    public Roulette_Color getColor() => color;

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Ball")
            master.setCurrentWheelNumber(this);
    }
}
