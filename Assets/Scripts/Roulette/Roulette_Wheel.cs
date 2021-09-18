using System.Collections;
using UnityEngine;

public class Roulette_Wheel : MonoBehaviour
{
    [Header("Scene References")]
    [SerializeField] private Roulette_Master master;

    [Header("Wheel Settings")]
    [SerializeField] private int spinStopSpeed = 1000;
    [SerializeField] private float spinSpeed = 1.5f;
    
    private int stopSpinLimit;

    public void startSpinning() {
        stopSpinLimit = Mathf.RoundToInt(spinSpeed * spinStopSpeed);
        StartCoroutine("SpinWheel");
    }

    IEnumerator SpinWheel() {
        while (spinSpeed > 0) {
            this.gameObject.transform.Rotate(0,spinSpeed,0);

            if (Input.GetKeyUp(KeyCode.Space)) StartCoroutine("StopSpinning");

            yield return null;
        }
    }

    IEnumerator StopSpinning() {
        for (int i = 1; i < stopSpinLimit; i++) {
            spinSpeed -= spinSpeed / spinStopSpeed;

            if (i == stopSpinLimit - 1) {
                spinSpeed = 0;
                master.finish();
            }

            yield return null;
        }
    }

}
