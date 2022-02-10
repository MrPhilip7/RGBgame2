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
    public GameObject aboutGameButtonCanvasStart;
    public GameObject aboutGameButtonCanvasRestart;
    public GameObject aboutGameCanvas;
    public GameObject exitAboutGameStart;
    public GameObject exitAboutGameRestart;
    public GameObject gifAnimation;
    public GameObject gifAnimation2;
    public GameObject gifAnimation3;
    public GameObject pointsAnimation;

    private static int counter;
    public bool isShowed = false;

    private void Start() {
        if (counter == 0) {
            Time.timeScale = 0;
            aboutGameButtonCanvasStart.SetActive(true);
        }
        else {
            Time.timeScale = 1;
            playButtonCanvas.SetActive(false);
            aboutGameButtonCanvasStart.SetActive(false);
            aboutGameButtonCanvasRestart.SetActive(false);
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
        aboutGameButtonCanvasStart.SetActive(false);
        menuButtonCanvas.SetActive(false);
        aboutGameButtonCanvasRestart.SetActive(false);
        Time.timeScale = 1;
        counter++;
    }

    public void GameOver() {
        menuButtonCanvas.SetActive(true);
        aboutGameButtonCanvasStart.SetActive(true);
        playButtonCanvas.SetActive(false);
        settingsButtonCanvas.SetActive(true);
        gifAnimation.SetActive(false);
        aboutGameButtonCanvasRestart.SetActive(true);
        Time.timeScale = 0;
    }

    public void RestartGame() {
        aboutGameButtonCanvasStart.SetActive(false);
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
        aboutGameCanvas.SetActive(false);
        aboutGameButtonCanvasStart.SetActive(false);
    }

    public void AboutGameShowStart() {
        menuButtonCanvas.SetActive(false);
        settingsCanvas.SetActive(false);
        settingsButtonCanvas.SetActive(false);
        aboutGameCanvas.SetActive(true);
        playButtonCanvas.SetActive(false);
        exitAboutGameStart.SetActive(true);
    }

    public void AboutGameShowRestart() {
        aboutGameCanvas.SetActive(true);
        menuButtonCanvas.SetActive(false);
        settingsCanvas.SetActive(false);
        settingsButtonCanvas.SetActive(false);
        aboutGameCanvas.SetActive(true);
        playButtonCanvas.SetActive(false);
        exitAboutGameRestart.SetActive(true);
    }

    public void ExitAboutGameStart() {
        playButtonCanvas.SetActive(true);
        aboutGameCanvas.SetActive(false);
    }

    public void ExitAboutGameRestart() {
        menuButtonCanvas.SetActive(true);
        aboutGameCanvas.SetActive(false);
        settingsButtonCanvas.SetActive(true);
    }

    public void BackToGameOver() {
        menuButtonCanvas.SetActive(true);
        settingsCanvas.SetActive(false);
    }

    public void QuitGame() {
        Application.Quit();
    }
}