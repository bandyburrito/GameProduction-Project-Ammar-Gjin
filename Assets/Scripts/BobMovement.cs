
using UnityEngine;

public class BobMovement : MonoBehaviour
{

    [SerializeField] private float moveSpeed = 10f;

    public Rigidbody2D rb;
    public float jumpSpeed = 10f;
    public float dashSpeed = 10f;

    private bool isGrounded;
    private bool hasDashed;

    private Vector2 InitialSpawn;
    private Vector2 spawnpoint1;

    private Vector2 spawnpoint2;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        InitialSpawn = new Vector2(0f, 0f);
        spawnpoint1 = new Vector2(34f, -4f);

    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");

        rb.linearVelocity = new Vector2(moveX * moveSpeed, rb.linearVelocity.y);

        if (Input.GetKeyDown(KeyCode.C) && isGrounded == true)
        {
            rb.AddForce(transform.up * jumpSpeed);
        }

        if (Input.GetKeyDown(KeyCode.X) && hasDashed == false)
        {
            rb.AddForce(transform.right * dashSpeed);
            hasDashed = true;
            Debug.Log("Has Dashed cannot Dash untill it hits the ground");
        }
    }


    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Debug.Log("isGrounded");
            isGrounded = true;
            hasDashed = false;
            Debug.Log("Is able to Dash Again!!!");
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            Debug.Log("isNotGrounded");
            isGrounded = false;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("DeathLine"))
        {
            transform.position = InitialSpawn;
        }

        if (collision.gameObject.CompareTag("SpawnPoint"))
        {
            InitialSpawn = spawnpoint1;
        }
        
        
        
        

        
    }


}
