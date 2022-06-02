using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimientocubo : MonoBehaviour
{
    float a;
    public float movementSpeed;
    public float rotationspeed;
    Rigidbody rb;
    public float jumpForce;

    void start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(0, 0, movementSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position -= new Vector3(0, 0, movementSpeed);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(movementSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(movementSpeed, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (a < 0.51f)
            {
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            }
        }
        a = transform.position.y;
    }
}
