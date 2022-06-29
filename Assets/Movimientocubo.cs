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
            transform.position += new Vector3(0, 0, movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position -= new Vector3(0, 0, movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(movementSpeed * Time.deltaTime, 0, 0);
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
        if(name == "barrera ladrillos")
        {
            transform.position = new Vector3(-94f, 2.63f, -25.5f);
        }
        if (name == "pared ladrillos")
        {
            transform.position = new Vector3(-94f, 2.63f, -25.5f);
        }
        if (name == "cone")
        {
            transform.position = new Vector3(-94f, 2.63f, -25.5f);
        }
        if (name == "muro")
        {
            transform.position = new Vector3(-94f, 2.63f, -25.5f);
        }
        if (name == "palos")
        {
            transform.position = new Vector3(-95.2f, 1.23f, -0.35f);
        }
        if (collision.gameObject.name == "meta")
        {
            SceneManager.LoadScene("ganaste");
        }
    }
}