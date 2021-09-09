using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : MonoBehaviour {
    private GameObject Character;
    public float Speed = 5f;
    public bool canControl;

    public void Start() {
        Character = transform.gameObject;
    }

    private void Update() {
        if (canControl == true) {
            float a = Input.GetAxis("Horizontal") * Speed;

            Character.transform.Translate(a * Time.deltaTime, 0, 0);
        }
    }
}