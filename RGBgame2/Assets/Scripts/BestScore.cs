using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BestScore : MonoBehaviour {
    public static int highscore;
    private TextMeshProUGUI textMesh;

    private void Start() {
        textMesh = GetComponent<TextMeshProUGUI>();
        PrintHighScore();
    }

    private void Update() {
        UpdateHighScore();
    }

    public void UpdateHighScore() {
        highscore = PlayerPrefs.GetInt("highscore", highscore);
        if (Score.scoreValue > highscore) {
            PlayerPrefs.SetInt("highscore", Score.scoreValue);
            PrintHighScore();
        }
    }

    private void PrintHighScore() {
        textMesh.text = PlayerPrefs.GetInt("highscore").ToString();
    }
}