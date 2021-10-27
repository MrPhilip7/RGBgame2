using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class LevelManager : MonoBehaviour {
    public GameObject playButtonCanvas;
    public GameObject menuButtonCanvas;
    public TextMeshProUGUI countdownDisplay;

    private void Start() {
    }

    public void Update() {
    }

    public void GameOver() {
        menuButtonCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void RestartGame() {
        countdownDisplay.gameObject.SetActive(false);
        SceneManager.LoadScene(0);
        menuButtonCanvas.SetActive(false);
        Score.scoreValue = 0;
        playButtonCanvas.SetActive(false);
        Time.timeScale = 1;
    }
}