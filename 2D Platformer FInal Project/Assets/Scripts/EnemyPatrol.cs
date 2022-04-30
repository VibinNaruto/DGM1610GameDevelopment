using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public float speed; 
    public float distance; 

    private bool moveRight = true;

    public Transform groundDectection;
    
    // Update is called once per frame
    void Update()
    {
        // Move Enemy to the Right 
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        RaycastHit2D groundInfo = Physics2D.Raycast(groundDectection.position, Vector2.down, distance);

        //This is pretty cool but this is how it flips the enemy using a 3D Vector. 
        if(groundInfo.collider == false)
        {
            if(moveRight == true)
            {
                // Flip Enemy to move left at edge
                transform.eulerAngles = new Vector3(0, -180, 0);
                moveRight = false;
            }
            else
            {
                // Flip Enenmy to move right at edge
                transform.eulerAngles = new Vector3(0,0,0);
                moveRight = true;
            }
        }
    }
}
