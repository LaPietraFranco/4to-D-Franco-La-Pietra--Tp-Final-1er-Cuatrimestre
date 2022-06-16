using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Movimientocubo : MonoBehaviour
{
    public float jumpHeight = 7;
    public float movementSpeed;
    public float rotationspeed;
    private Rigidbody rb;
    public float jumpForce;
    public Text  txt_GanastePerdiste;
    void start()
    {
        
    }
    void Update()
    {
        rb = GetComponent<Rigidbody>();
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


    }
    void OnCollisionStay(Collision collision)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector3.up * jumpHeight;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        name = collision.gameObject.name;
        if(name == "barrera1")
        {
            SceneManager.LoadScene("SampleScene");
        }
        if(name == "palos")
        {
            SceneManager.LoadScene("SampleScene");
        }
        if (collision.gameObject.name == "meta")
        {
            SceneManager.LoadScene("ganaste");
        }
    }
}