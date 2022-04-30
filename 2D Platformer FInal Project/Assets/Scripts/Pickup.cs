using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public enum PickupType {Key, Coin, Gem};

    public PickupType currentPickup;

    public int pickupAmount;

    private PlayerMovement playerMovement;

    // Start is called before the first frame update
    void Start()
    {
        playerMovement = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }

    // Longer code but all this does is show the amount coins, keys, and gems, they woll have when they pickup the onject 
void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            if(currentPickup == PickupType.Key)
            {
                playerMovement.keys = pickupAmount;

                Debug.Log("You have picked up the golden egg");
            }
            else if(currentPickup == PickupType.Coin)
            {
                playerMovement.coins += pickupAmount;
                Debug.Log("You have picked up" + pickupAmount + "coin");
            }
            else if(currentPickup == PickupType.Gem)
            {
                playerMovement.gems += pickupAmount;
                Debug.Log("You have picked up" + pickupAmount + "Gems");
            }
            Destroy(gameObject);
        }
    }
}
