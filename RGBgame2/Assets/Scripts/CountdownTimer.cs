using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountdownTimer : MonoBehaviour {
    public int countdownTime;
    public TextMeshProUGUI countdownDisplay;
    private static int cnt = 0;

    private void Start() {
        if (cnt == 0) {
            StartCoroutine(CountdownToStart());
        }
        else {
            countdownDisplay.gameObject.SetActive(false);
        }
    }

    private void Update() {
    }

    private IEnumerator CountdownToStart() {
        while (countdownTime > 0) {
            countdownDisplay.text = countdownTime.ToString();

            yield return new WaitForSeconds(1f);

            countdownTime--;
        }

        countdownDisplay.text = "GO!";

        yield return new WaitForSeconds(1f);

        countdownDisplay.gameObject.SetActive(false);

        cnt++;
    }
}