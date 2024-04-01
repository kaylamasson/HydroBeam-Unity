using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour
{

    public GameObject UI;
    public GameObject button1;
    public GameObject button2;

    void Update()
    {

        if (Input.GetMouseButtonDown(1))
        {
        UI.SetActive(false);
        gameObject.SetActive(false);
        button1.SetActive(false);
        button2.SetActive(false);
        
        }



    }
}
