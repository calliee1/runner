using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class playerMov : MonoBehaviour
{
    public AudioClip jump;
    public AudioClip backgroundMusic;

    public AudioSource sfxPlayer;
    public AudioSource musicPlayer;

    public float moveSpeed = 2f;
    public float jumpForce = 10f;
    public Transform groundCheckPoint;
    public float checkRadius = 0.2f;
    public LayerMask groundLayer;

    private Rigidbody2D rb;
    private bool isGrounded;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sfxPlayer = GetComponent<AudioSource>();

        // Initialize and loop background music
        musicPlayer.loop = true;
        musicPlayer.clip = backgroundMusic;
        musicPlayer.Play();
        //anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Constant forward movement
        rb.velocity = new Vector2(moveSpeed, rb.velocity.y);

        // Check if the player is grounded
        isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, checkRadius, groundLayer);

        if(isGrounded)
        {
            anim.SetBool("isOnGround", true);
        }
        if (!isGrounded)
        {
            anim.SetBool("isOnGround", false);
        }

        // Jumping logic
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
            sfxPlayer.PlayOneShot(jump); // Play jump sound only when jumping
            anim.SetTrigger("Jump");
        }
    }

    private void Jump()
    {
        // Add an upward force for jumping
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);

    }

}

        