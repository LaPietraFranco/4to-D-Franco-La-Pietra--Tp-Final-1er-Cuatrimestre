using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class INs : MonoBehaviour
{
    GameObject clon;
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            for (int i = 0; i < 2; i++)
            {
                GameObject capsule = Instantiate(prefab, transform.position, transform.rotation) as GameObject;
                capsule.name = "Capsule";

                //prefab = Instantiate(clon, transform.position, transform.rotation);
                Destroy(clon, 2f);
            }
        }
    }
}
