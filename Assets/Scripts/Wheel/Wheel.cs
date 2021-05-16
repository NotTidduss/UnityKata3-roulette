using System.Collections;
using UnityEngine;

public class Wheel : MonoBehaviour
{
    public int spinStopSpeed = 1000;
    private float spinFactor = 1.5f;
    private int stopSpinLimit;

    public void startSpinning(float spinSpeed) {
        spinFactor = spinSpeed;
        stopSpinLimit = Mathf.RoundToInt(spinFactor * spinStopSpeed);

        StartCoroutine("SpinWheel");
    }

    IEnumerator SpinWheel() {
        while (spinFactor > 0) {
            this.gameObject.transform.Rotate(0,spinFactor,0);

            if (Input.GetKeyUp(KeyCode.Space)) StartCoroutine("StopSpinning");

            yield return null;
        }
    }

    IEnumerator StopSpinning() {
        for (int i = 0; i < stopSpinLimit; i++) {
            spinFactor -= spinFactor / spinStopSpeed;

            if (i == stopSpinLimit - 1) {
                spinFactor = 0;
                GameObject.Find("Master").GetComponent<Master>().finish();
            }

            yield return null;
        }
    }

}
