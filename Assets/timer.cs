using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class timer : MonoBehaviour
{
    //public int SegundosTotales;
        private float contador;
    public Text txttimer;
    //private bool dejardecontar = false;
    public GameObject Panel;
    // Start is called before the first frame update
    void Start()
    {
        contador = Time.time;
    }

    // Update is called once per frame
    void Update()
    {

        txttimer.text = Mathf.FloorToInt(Time.time).ToString();
        //if(Time.time > contador + 1)
        //{
            //contador++;
            //SegundosTotales++;
        //}
        //if(!dejardecontar)
        //{
            //cuentaregresiva.text = SegundosTotales.ToString();
        //}
        //if(SegundosTotales == 0)
        //{
            //dejardecontar = true;
            //SceneManager.LoadScene("SampleScene");
        //}
    }
}
