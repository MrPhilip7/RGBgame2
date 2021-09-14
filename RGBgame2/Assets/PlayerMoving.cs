using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : MonoBehaviour {
    private Rigidbody2D rb;
    public float Speed = 5f;
    public bool canControl;
    public bool canCollision;

    public void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate() {
        if (canControl == true) {
            float x = Input.GetAxis("Horizontal") * Speed;

            rb.MovePosition(rb.position + Vector2.right * x);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (canCollision == true) {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}