using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour
{
    // These are some Variables the show startpoint and player.
    public GameObject startPoint;
    public GameObject Player;
    
    // This line of code when the player touches the object with the tag it will go back to the start point I set in the level.
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Player.transform.position = startPoint.transform.position;
        }
    }
}
