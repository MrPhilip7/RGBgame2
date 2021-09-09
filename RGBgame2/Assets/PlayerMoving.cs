using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : MonoBehaviour
{
    public GameObject Character;
    public float Speed = 5f;
    public bool canControl;

    private void Update()
    {
        if (canControl == true)
        {
            float a = Input.GetAxis("Horizontal") * Speed;

            Character.transform.Translate(a * Time.deltaTime, 0, 0);
        }
    }
}