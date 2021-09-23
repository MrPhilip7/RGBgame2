using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColorSwitcher : MonoBehaviour {
    public SpriteRenderer playerRend;

    private Color[] colors = new Color[3];

    // Start is called before the first frame update
    private void Start() {
        colors[0] = Color.red;
        colors[1] = Color.green;
        colors[2] = Color.blue;
        PlayerColor();
    }

    // Update is called once per frame
    private void Update() {
    }

    private void PlayerColor() {
        playerRend.color = colors[Random.Range(0, 3)];
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        PlayerColor();
    }
}