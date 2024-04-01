using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back : MonoBehaviour
{

    public GameObject removeUI;

    public GameObject addUI;
    public GameObject menuButton1;
    public GameObject menuButton2;
    public GameObject menuButton3;

    void Update()
    {

        if (Input.GetMouseButtonDown(1))
        {
            removeUI.SetActive(false);
            gameObject.SetActive(false);
            addUI.SetActive(true);
            menuButton1.SetActive(true);
            menuButton2.SetActive(true);
            menuButton3.SetActive(true);

        }



    }
}
