using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour {
    public Transform[] spawnPoints;

    public GameObject blockPrefab;

    public float wavesTime = 1f;

    private float spawnTime = 2f;

    // Start is called before the first frame update
    private void Update() {
        if (Time.time >= spawnTime) {
            SpawnBlocks();
            spawnTime = Time.time + wavesTime;
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
}