using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChase : MonoBehaviour
{

    // Variables that help you change the speed and you can determine how insane the enemy could be!
    public GameObject player;
    public float speed;

    private float distance; 

    // Update is called once per frame
    void Update()
    {
        // Simple code that allow the enemy follow the player around and it will keep the position of the player. 
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;

        transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
    }
}
