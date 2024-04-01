using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraClamp : MonoBehaviour
{

    [SerializeField]
    public Transform targetToFollow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector3(
            Mathf.Clamp(targetToFollow.position.x, -52.92f, 54.5f),
            Mathf.Clamp(targetToFollow.position.y, 0f,0f),
            transform.position.z);
    }
}
