using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class PlatformMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private BoxCollider2D coll;
    private SpriteRenderer sprite;
    private Animator anim;

    private float dirX = 0f;
    private bool facingright = true;
    public bool doubleJump;
    [SerializeField] bool hasDouble = false;
    public Transform groundCheck;
    [SerializeField] private LayerMask jumpableGround;//creates the layermask used by boxcast
    [SerializeField] private float moveSpeed = 7f;
    [SerializeField] private float jumpForce = 13.5f;


    [SerializeField] private AudioSource jumpSoundEffect;
    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        moveSpeed = 7f;
        jumpForce = 14f;
        
    }

    private void Update()
    {
        float dirX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);
        if (facingright == false && dirX > 0)
        {
            flip();
        }
        else if (facingright == true && dirX < 0)
        {
            flip();
        }
        if (Input.GetButtonDown("Jump") )
        {
            if(!hasDouble)
            {
                if (isGrounded())
                {
                    Jump();
                }
            }
            else
            {
                if (isGrounded())
                {
                    Jump();
                    doubleJump = true;
                }
                else if (doubleJump)
                {
                    Jump();
                    doubleJump = false;
                }
            }    
        }
        
    }
    private void FixedUpdate()
    {
    }

    void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }

    void flip()
    {
        facingright = !facingright;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
    private bool isGrounded()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
    }


}