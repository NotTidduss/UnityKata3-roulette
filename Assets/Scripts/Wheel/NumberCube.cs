using UnityEngine;

public class NumberCube : MonoBehaviour
{
    public RouletteColor rouletteColor;
    private Master mRef;

    void Start() => mRef = GameObject.Find("Master").GetComponent<Master>();

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Ball")
            mRef.setRouletteNumber(rouletteColor);
    }
}
