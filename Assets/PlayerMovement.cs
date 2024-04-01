using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 10f;

    float horizontalInput;
    private Rigidbody2D rb;
    
    bool isFacingRight = false;
    float jumpPower = 6f; 
    bool isJumping = false;

    void Start()
    {
        //velocity = new Vector2(speed, speed);
        rb = GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        //print(horizontalInput);

        FlipSprite();

        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
            isJumping = true;
        }
    }

    

    void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontalInput * speed, rb.velocity.y);
    }




    
    void FlipSprite()
    {
        if (isFacingRight && horizontalInput < 0f || !isFacingRight && horizontalInput > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 ls = transform.localScale;
            ls.x *= -1f;
            transform.localScale = ls;
        }
    }

    

    


    private void OnCollisionEnter2D(Collision2D collision)
    {
        isJumping = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("battery_pink"))
        {
            
            //print("We have collected an item!");
        }

        //Destroy(collision.gameObject);
    }
    
}

