using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject target;

    // Update is called once per frame
    void Update()
    {
        // Simple one line code that works for following the player and it dosen't rotate the whole screen. 
        transform.position = new Vector3(target.transform.position.x, transform.position.y, -10);
    }
}
