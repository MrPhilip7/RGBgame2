using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour {
    public static int scoreValue = 0;
    private TextMeshProUGUI score;

    // Start is called before the first frame update
    private void Start() {
        score = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    private void Update() {
        score.text = scoreValue.ToString();
    }
}