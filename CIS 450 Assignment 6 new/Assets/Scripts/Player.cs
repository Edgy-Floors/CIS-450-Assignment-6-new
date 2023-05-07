using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public int health = 100;
    public int damage = 10;
    public float moveSpeed = 5.0f;
    public float jumpForce = 7.0f;
    public LayerMask groundLayer;

    private Rigidbody rb;
    private bool isGrounded;

    public TextMeshProUGUI tmp;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0, vertical);
        movement.Normalize();

        rb.velocity = new Vector3(movement.x * moveSpeed, rb.velocity.y, movement.z * moveSpeed);

        isGrounded = Physics.Raycast(transform.position, Vector3.down, GetComponent<Collider>().bounds.extents.y + 0.1f, groundLayer);
    
        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        if(Input.GetKeyDown(KeyCode.E))
        {
            tmp.text = "Health: " + health + ".\nDamage: " + damage + ".";
        }
    }
}
