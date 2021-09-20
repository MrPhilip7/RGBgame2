using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour {
    public Transform[] spawnPoints;

    public GameObject blockPrefab;

    public SpriteRenderer xrenderer;

    private Color[] colors = new Color[6];

    public float wavesTime = 1f;

    private float spawnTime = 2f;

    // Start is called before the first frame update
    private void Start() {
        colors[0] = Color.red;
        colors[1] = Color.green;
        colors[2] = Color.blue;
    }

    private void Update() {
        if (Time.time >= spawnTime) {
            SpawnBlocks();
            spawnTime = Time.time + wavesTime;
            ColorSwitcher();
        }
    }

    private void SpawnBlocks() {
        int randomIndex = 3;

        for (int i = 0; i < spawnPoints.Length; i++) {
            if (randomIndex != i) {
                Instantiate(blockPrefab, spawnPoints[i].position, Quaternion.identity);
            }
        }
    }

    private void ColorSwitcher() {
        xrenderer.color = colors[Random.Range(0, 3)];
    }

    // private void ColorChecker() {
    //  }
}