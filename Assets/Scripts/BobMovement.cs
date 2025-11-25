using UnityEngine;

public class BobMovement : MonoBehaviour
{

    [SerializeField] private float moveSpeed = 10f;

    public Rigidbody2D rb;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");

        rb.linearVelocity = new Vector2(moveX * moveSpeed * Time.deltaTime, rb.linearVelocity.y);

        
    }
}
