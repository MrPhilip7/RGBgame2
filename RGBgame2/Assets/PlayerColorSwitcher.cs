using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColorSwitcher : MonoBehaviour {
    public SpriteRenderer playerRend;

    [SerializeField] private GameObject blockPrefab, blockPrefab2, blockPrefab3;
    [SerializeField] private SpriteRenderer xrenderer, xrenderer2, xrenderer3;

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
        FindObjectOfType<BlockSpawner>().ColorSwitcher();
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        Debug.Log(collision.gameObject.name);
        Debug.Log(playerRend.color);
        Debug.Log(xrenderer.color);
        Debug.Log(xrenderer2.color);
        Debug.Log(xrenderer3.color);
        if (collision.gameObject.name == "Square(Clone)") {
            if (playerRend.color == xrenderer.color) {
                Debug.Log("Ten sam kolor");
                Destroy(collision.gameObject);
            }
            else {
                Debug.Log("Inny kolor");
                FindObjectOfType<GameManager>().EndGame();
            }
        }
        if (collision.gameObject.name == "Square 1(Clone)") {
            if (playerRend.color == xrenderer2.color) {
                Debug.Log("Ten sam kolor");
                Destroy(collision.gameObject);
            }
            else {
                Debug.Log("Inny kolor");
                FindObjectOfType<GameManager>().EndGame();
            }
        }
        if (collision.gameObject.name == "Square (2)(Clone)") {
            if (playerRend.color == xrenderer3.color) {
                Debug.Log("Ten sam kolor");
                Destroy(collision.gameObject);
            }
            else {
                Debug.Log("Inny kolor");
                FindObjectOfType<GameManager>().EndGame();
            }
        }

        //FindObjectOfType<BlockSpawner>().ColorSwitcher();

        PlayerColor();
    }
}