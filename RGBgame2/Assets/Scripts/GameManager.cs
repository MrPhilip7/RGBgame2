using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public LevelManager levelManager;

    public float slowness = 10f;

    public void EndGame() {
        StartCoroutine(RestartLevel());
        IEnumerator myWaitCoroutineGameOver() {
            yield return new WaitForSeconds(0.2f);

            levelManager.GameOver();
        }
        StartCoroutine(myWaitCoroutineGameOver());
        
    }

    private IEnumerator RestartLevel() {
        Time.timeScale = 1f / slowness;
        Time.fixedDeltaTime = Time.fixedDeltaTime / slowness;

        yield return new WaitForSeconds(0.8f / slowness);

        Time.timeScale = 1f;
        Time.fixedDeltaTime = Time.fixedDeltaTime * slowness;

        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}