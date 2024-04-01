using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCell : MonoBehaviour
{

    public List<GameObject> batteries; 
    public GameObject cellUI;


    private void Start(){
        batteries = new List<GameObject>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            cellUI.SetActive(true);
            gameObject.SetActive(false);
            batteries.Add(collision.gameObject);
            print(batteries.Count);
            
        }    
        
    }
}
