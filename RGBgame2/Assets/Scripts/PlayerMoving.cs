using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : MonoBehaviour {
    private Rigidbody2D rb;
    public float speed;
    public bool canControl;

    public void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate() {
        var movement = Input.GetAxis("Horizontal");

        //Usuniecie 'slizgania'
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * speed;

        if (Input.GetKey(KeyCode.A)) {
            rb.AddForce(Vector3.left);
        }
        if (Input.GetKey(KeyCode.D)) {
            rb.AddForce(Vector3.right);
        }
    }
}