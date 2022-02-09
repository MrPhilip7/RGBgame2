using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
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
    public GameObject gifAnimation2;
    public GameObject gifAnimation3;
    public GameObject pointsAnimation;

    private static int counter;
    public bool isShowed = false;

    private void Start() {
        if (counter == 0) {
            Time.timeScale = 0;
            aboutGameButtonCanvas.SetActive(true);
        }
        else {
            Time.timeScale = 1;
            playButtonCanvas.SetActive(false);
            aboutGameButtonCanvas.SetActive(false);
        }
    }

    public void Update() {
        if (Score.scoreValue >= 1 && Score.scoreValue % 5 == 0) {
            if (!isShowed) {
                AnimationPoints();
                isShowed = true;
            }
        }
        else {
            gifAnimation.SetActive(false);
            gifAnimation2.SetActive(false);
            gifAnimation3.SetActive(false);
            pointsAnimation.SetActive(true);
            isShowed = false;
        }
    }

    private void AnimationPoints() {
        IEnumerator waitForAninmation() {
            gifAnimation.SetActive(true);
            yield return new WaitForSeconds(0.2f);
            gifAnimation.SetActive(false);
            gifAnimation2.SetActive(true);
            yield return new WaitForSeconds(0.2f);
            gifAnimation2.SetActive(false);
            gifAnimation3.SetActive(true);
            yield return new WaitForSeconds(0.2f);
            gifAnimation3.SetActive(false);
            pointsAnimation.SetActive(false);
        }
        StartCoroutine(waitForAninmation());
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
        menuButtonCanvas.SetActive(false);
        settingsCanvas.SetActive(true);
    }

    public void AboutGameShow() {
        aboutGameCanvas.SetActive(true);
    }

    public void ExitAboutGame() {
        aboutGameCanvas.SetActive(false);
    }

    public void BackToGameOver() {
        menuButtonCanvas.SetActive(true);
        settingsCanvas.SetActive(false);
    }

    public void QuitGame() {
        Application.Quit();
    }
}