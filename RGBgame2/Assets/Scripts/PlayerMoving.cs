using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : MonoBehaviour {
    private Rigidbody2D rb;
    public float speed = 0.3f;
    public bool canControl;
    public bool canCollision;

    public void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update() {
        if (canControl == true) {
            float x = Input.GetAxis("Horizontal") * 0.3f;

            rb.MovePosition(rb.position + Vector2.right * x);
        }
    }
}