using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10f;
    private float turnspeed = 40f;

    private float horizontalInput;
    private float verticalInput;

    void Update()
    {
        //Movimiento horizontal
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * turnspeed * Time.deltaTime * horizontalInput);
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
    }
}
