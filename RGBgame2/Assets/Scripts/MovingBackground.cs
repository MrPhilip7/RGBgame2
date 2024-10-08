using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBackground : MonoBehaviour
{
    public float speed = 1f;
    public float pos;
[HideInInspector] public Vector3 StartPosition;

    // Start is called before the first frame update
    void Start()
    {
        StartPosition = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float newPosition = Mathf.Repeat(Time.time * speed, pos);
        transform.position = StartPosition + Vector3.down * newPosition;
    }
}
