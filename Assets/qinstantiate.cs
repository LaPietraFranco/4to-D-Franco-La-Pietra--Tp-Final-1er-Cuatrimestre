using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class qinstantiate : MonoBehaviour
{
    GameObject clon;
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
       
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            for (int i = 0; i < 12; i++)
            {
                GameObject capsule = Instantiate(prefab, gameObject.transform.position, Quaternion.identity);
                capsule.name = "Capsule";

                //prefab = Instantiate(clon, transform.position, transform.rotation);
                Destroy(clon, 4f);
            }
        }
    }
}
