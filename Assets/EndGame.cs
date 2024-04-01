using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public GameObject cellUI;
    public GameObject failUI;
    public GameObject[] lights;


     private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            foreach (GameObject light in lights){
                if (light.activeInHierarchy) {
                    failUI.SetActive(true);
                    return;
                }
            }

            cellUI.SetActive(true);
            //gameObject.SetActive(false);
            
        } 
        
    }

}
