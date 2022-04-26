using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
     private PlayerMovement playerMovement;

    // Start is called before the first frame update
    void Start()
    {
         playerMovement = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player") && playerMovement.keys == 1)
        {
            Debug.Log("You have opened the door");
            Destroy(gameObject);
        }
        else 
        {
            Debug.Log("Door  is Locked, you need a key");
        }
    }
}
