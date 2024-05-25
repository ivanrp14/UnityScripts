using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 5f, jumpForce = 5f;
    private bool isGrounded = true, isJumping = false;
    public LayerMask groundLayers;
    
    // Variables para el movimiento horizontal
    private float horizontalInput;
    private Animator animator;
    public float minX = -5f, maxX = 5f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
         Movement();
        Jump();

        
    }
    void Movement(){
         // Movimiento horizontal
        horizontalInput = Input.GetAxis("Horizontal");
        transform.position += new Vector3(horizontalInput * speed * Time.deltaTime, 0f,0f);
        float x = Mathf.Clamp(transform.position.x, minX,maxX);
        transform.position = new Vector3(x, transform.position.y, 0f);
        // Rotación del jugador
        if (horizontalInput != 0f)
        {
            
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0f, Mathf.Sign(horizontalInput) * 45f, 0f), Time.deltaTime * 5f);
        }
        else
        {
            
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0f, 0f, 0f), Time.deltaTime * 5f);
        }
    }
    void Jump(){
        // Salto
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isJumping = true;
            animator.SetBool("Jumping", true);
            
        }
        if(rb.velocity.y < -2f){
            animator.SetBool("Falling", true);
        }
        
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            isJumping = false;
            isGrounded = true;
            animator.SetBool("Jumping", false);
            animator.SetBool("Falling", false);
        }
    }
}
