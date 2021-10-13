using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour {
    public Transform[] spawnPoints;

    public GameObject blockPrefab;
    public GameObject blockPrefab2;
    public GameObject blockPrefab3;

    public SpriteRenderer xrenderer;
    public SpriteRenderer xrenderer2;
    public SpriteRenderer xrenderer3;

    public float wavesTime = 1f;

    private float spawnTime = 2f;

    private void Start() {
    }

    private void FixedUpdate() {
        if (Time.time >= spawnTime) {
            SpawnBlocks();
            SpawnBlocks2();
            SpawnBlocks3();
            spawnTime = Time.time + wavesTime;
        }
    }

    private void SpawnBlocks() {
        for (int i = 0; i < 1; i++) {
            if (1f != i) {
                Instantiate(blockPrefab, spawnPoints[0].position, Quaternion.identity);
            }
        }
    }

    private void SpawnBlocks2() {
        for (int i = 0; i < 1; i++) {
            if (1f != i) {
                Instantiate(blockPrefab2, spawnPoints[1].position, Quaternion.identity);
            }
        }
    }

    private void SpawnBlocks3() {
        for (int i = 0; i < 1; i++) {
            if (1f != i) {
                Instantiate(blockPrefab3, spawnPoints[2].position, Quaternion.identity);
            }
        }
    }

    public void ColorSwitcher() {
        switch (Random.Range(0, 6)) {
            case 0:
                xrenderer.color = Color.red;
                xrenderer2.color = Color.green;
                xrenderer3.color = Color.blue;
                break;

            case 1:
                xrenderer.color = Color.red;
                xrenderer2.color = Color.blue;
                xrenderer3.color = Color.green;
                break;

            case 2:
                xrenderer.color = Color.green;
                xrenderer2.color = Color.blue;
                xrenderer3.color = Color.red;
                break;

            case 3:
                xrenderer.color = Color.green;
                xrenderer2.color = Color.red;
                xrenderer3.color = Color.blue;
                break;

            case 4:
                xrenderer.color = Color.blue;
                xrenderer2.color = Color.red;
                xrenderer3.color = Color.green;
                break;

            case 5:
                xrenderer.color = Color.blue;
                xrenderer2.color = Color.green;
                xrenderer3.color = Color.red;
                break;
        }
    }
}