using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class LevelManager : MonoBehaviour {
    public GameObject playButtonCanvas;
    public GameObject menuButtonCanvas;
    public GameObject settingsButtonCanvas;
    public GameObject exitGameButton;
    public GameObject settingsCanvas;
    public TextMeshProUGUI countdownDisplay;

    private static int counter;

    private void Start() {
        if (counter == 0) {
            Time.timeScale = 0;
            countdownDisplay.gameObject.SetActive(false);
        }
        else {
            Time.timeScale = 1;
            playButtonCanvas.SetActive(false);
        }
    }

    public void Update() {
    }

    public void PlayGame() {
        //countdownDisplay.gameObject.SetActive(true);              resolution problem
        playButtonCanvas.SetActive(false);
        menuButtonCanvas.SetActive(false);
        Time.timeScale = 1;
        counter++;
    }

    public void GameOver() {
        menuButtonCanvas.SetActive(true);
        playButtonCanvas.SetActive(false);
        settingsButtonCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void RestartGame() {
        countdownDisplay.gameObject.SetActive(false);
        SceneManager.LoadScene(0);
        menuButtonCanvas.SetActive(false);
        Score.scoreValue = 0;
        playButtonCanvas.SetActive(false);
        settingsButtonCanvas.SetActive(false);
        Time.timeScale = 1;
    }

    public void SettingsShow() {
        settingsCanvas.SetActive(true);
    }

    public void BackToGameOver() {
        settingsCanvas.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}