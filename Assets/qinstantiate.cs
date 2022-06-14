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

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnColiisionEnter(Collision col)
    {
        for(int i = 0; i < 12; i++)
        {
           clon = Instantiate(prefab);
            clon.transform.position = transform.position += new Vector3(77.37f, 4f, 1.5f);
            Destroy(clon, 1);
        }
    }
}
