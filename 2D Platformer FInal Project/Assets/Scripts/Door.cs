using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
     private PlayerMovement playerMovement;

    // Start is called before the first frame update
    void Start()
    {
        // Looks for the player when it's tagged.
         playerMovement = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }

    // This code helps the game realize that you have opened the door and with the tag it will destroy the door in you have the key.
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player") && playerMovement.keys == 1)
        {
            Debug.Log("You have opened the door");
            Destroy(gameObject);
        }
        else 
        {
            // This will come up if you don't have the key to open door.
            Debug.Log("Door  is Locked, you need a key");
        }
    }
}
