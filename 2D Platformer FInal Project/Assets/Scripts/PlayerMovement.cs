using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private float Move;

    public float jump;

    public bool isJumping;

    private Rigidbody2D rb;

    public AudioClip marker;

    private AudioSource source;

    [Header("Inventory")]
    public int keys;
    public int coins;
    public int gems;

    // Start is called before the first frame update
    void Start()
    {
        // This referecnes the variable of the RigidBody. 
        rb = GetComponent<Rigidbody2D>();

        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // This code handles the Jump 
        Move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(speed * Move, rb.velocity.y);

        if (Input.GetButtonDown("Jump") && isJumping == false)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
            Debug.Log("jump");
        }
    }
    public void Jump()
    {
        source.PlayOneShot(marker, 1.0f);
    }

    // This is the groundcheck, to make sure the player is colliding with the floor. This prevents double jump so it's fair. 
    // But you have to create a ground Tag so this works
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = true;
        }
    }
}
