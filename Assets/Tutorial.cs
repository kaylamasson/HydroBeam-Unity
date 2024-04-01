using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{

    public GameObject removeUI;
    public GameObject button1;
    public GameObject button2;

    public GameObject addUI;

    public GameObject addButton;

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
        removeUI.SetActive(false);
        gameObject.SetActive(false);
        button1.SetActive(false);
        button2.SetActive(false);
        addUI.SetActive(true);
        addButton.SetActive(true);


        }



    }
}