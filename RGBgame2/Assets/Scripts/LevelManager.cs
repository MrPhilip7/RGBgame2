using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
    public GameObject playButtonCanvas;
    public GameObject menuButtonCanvas;
    public bool isLive = false;
    public int counter = 1;

    // Start is called before the first frame update
    private void Start() {
        Time.timeScale = 1;
        isLive = false;
    }

    public void Update() {
    }

    public void PlayGame() {
        playButtonCanvas.SetActive(false);
        menuButtonCanvas.SetActive(false);
        //  Score.scoreValue = 0;
        Time.timeScale = 1;
        isLive = true;
        // FindObjectOfType<GameManager>().EndGame();
    }

    public void GameOver() {
        isLive = false;
        menuButtonCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void RestartGame() {
        isLive = true;
        SceneManager.LoadScene(0);
        menuButtonCanvas.SetActive(false);
        Score.scoreValue = 0;
        playButtonCanvas.SetActive(false);
        Time.timeScale = 1;
    }
}