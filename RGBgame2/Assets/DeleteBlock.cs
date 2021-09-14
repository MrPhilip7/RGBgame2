using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteBlock : MonoBehaviour {

    private void Update() {
        if (transform.position.y < -6f) {
            Destroy(gameObject);
        }
    }
}