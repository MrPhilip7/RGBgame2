using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteBlock : MonoBehaviour {

    void Start()
    {
        GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad / 50f;
    }

    private void Update() {
        if (transform.position.y < -6f) {
            Destroy(gameObject);
        }
    }
}