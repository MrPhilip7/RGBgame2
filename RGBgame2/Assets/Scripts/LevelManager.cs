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
    public GameObject aboutGameButtonCanvas;
    public GameObject aboutGameCanvas;
    public GameObject exitAboutGame;
    public GameObject gifAnimation;

    private static int counter;

    private void Start() {
        if (counter == 0) {
            Time.timeScale = 0;
            aboutGameButtonCanvas.SetActive(true);
        }
        else {
            Time.timeScale = 1;
            playButtonCanvas.SetActive(false);
        }
    }

    public void Update() {
        if (Score.scoreValue >= 1 && Score.scoreValue % 5 == 0) {
            gifAnimation.SetActive(true);
        }
        else {
            gifAnimation.SetActive(false);
        }
    }

    public void PlayGame() {
        playButtonCanvas.SetActive(false);
        aboutGameButtonCanvas.SetActive(false);
        menuButtonCanvas.SetActive(false);
        aboutGameButtonCanvas.SetActive(false);
        Time.timeScale = 1;
        counter++;
    }

    public void GameOver() {
        menuButtonCanvas.SetActive(true);
        aboutGameButtonCanvas.SetActive(true);
        playButtonCanvas.SetActive(false);
        settingsButtonCanvas.SetActive(true);
        gifAnimation.SetActive(false);
        Time.timeScale = 0;
    }

    public void RestartGame() {
        aboutGameButtonCanvas.SetActive(false);
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

    public void AboutGameShow() {
        aboutGameCanvas.SetActive(true);
    }

    public void ExitAboutGame() {
        aboutGameCanvas.SetActive(false);
    }

    public void BackToGameOver() {
        settingsCanvas.SetActive(false);
    }

    public void QuitGame() {
        Application.Quit();
    }
}