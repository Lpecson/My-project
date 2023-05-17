using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody2D))]

public class PlayerController : MonoBehaviour
{

    private Rigidbody2D rb;
    private BoxCollider2D coll;
    private Animator anim;
    private bool facingright = true;
    public bool doubleJump;
    public Transform groundCheck;
    [SerializeField] int hasDouble;
    [SerializeField] private LayerMask jumpableGround;//creates the layermask used by boxcast
    [SerializeField] private LayerMask jumpableGroundTrap;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpForce;
    [SerializeField] public GameInfo gameInfo;
    [SerializeField] private AudioSource jumpSoundEffect;
    [SerializeField] public int hp;
    public Transform LaunchOffsetright;
    public Transform LaunchOffsetright2;
    public ProjectileBehavior ProjectilePrefab;
    private SpriteRenderer sRend;
    private Sprite cowboySprite, pirateSprite;
    private bool isCowboy;
    public bool shootright;
    public bool twoshot;
    public int dmg;
    private Player_life lifescript;
  
    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
        sRend = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        moveSpeed = gameInfo.PlayerMS;
        jumpForce = gameInfo.PlayerJumpHeight;
        hasDouble = gameInfo.PlayerHasDouble;
        dmg = gameInfo.PlayerDMG;
        isCowboy = gameInfo.isCowboy;
        hp = gameInfo.PlayerHPTotal;
        cowboySprite = Resources.Load<Sprite>("LukasCowboy");
        pirateSprite = Resources.Load<Sprite>("LukasPirate");
        sRend.sprite = cowboySprite;
        twoshot = gameInfo.doubleShot;
        if (isCowboy)
        {
            Debug.Log("Changing character sprite to cowboy");
            sRend.sprite = cowboySprite;
        }
        else
        {
            Debug.Log("Changing character sprite to pirate");
            sRend.sprite = pirateSprite;
        }
        gameInfo.currentLevel = SceneManager.GetActiveScene().buildIndex;
    }

    private void Update()
    {
        if(Input.GetKeyDown("a"))
        {
            Debug.Log("Facing left");
            shootright = false;
        }
        if(Input.GetKeyDown("d"))
        {
            Debug.Log("Facing right");
            shootright = true;
        }
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
            if(hasDouble == 0)
            {
                if (isGrounded() || isGroundedTrap())
                {
                    Jump();
                }
            }
            else
            {
                if (isGrounded() || isGroundedTrap())
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
        if(Input.GetButtonDown("Ranged"))
        {
            Instantiate(ProjectilePrefab, LaunchOffsetright.position, transform.rotation);
            if(twoshot)
            {
                Instantiate(ProjectilePrefab, LaunchOffsetright2.position, transform.rotation);
            }
            
        }
    }
    private void FixedUpdate()
    {
    }
    public void getDouble()
    {
        gameInfo.GetDouble();
        hasDouble = gameInfo.PlayerHasDouble;
    }
    public void getThorns()
    {
        gameInfo.havthorns();
    }
    public void getDoubleShot()
    {
        gameInfo.getDS();
        twoshot = gameInfo.doubleShot;
    }
    public void WinGame()
    {
        SceneManager.LoadScene("WinScreen");
    }
    public void LoseGame()
    {
        SceneManager.LoadScene("GameOver");
    }
    public void sacJump()
    {
        gameInfo.PlayerHPRemaining = 1;
        gameInfo.PlayerJumpHeight = gameInfo.PlayerJumpHeight*2;
    }
    public void sacSpeed()
    {
        gameInfo.PlayerHPRemaining = 1;
        gameInfo.PlayerJumpHeight = gameInfo.PlayerMS*2;
    }
    public void riskIt()
    {
        gameInfo.PlayerHPRemaining = 1;
        gameInfo.PlayerHPTotal = 1;
        gameInfo.PlayerJumpHeight = gameInfo.PlayerJumpHeight*2;
        gameInfo.PlayerJumpHeight = gameInfo.PlayerMS*2;
    }
    public void getBomb()
    {
        gameInfo.PlayerHPRemaining = 1;
    }
    public void getHealthPotion()
    {
       gameInfo.ResetHealth();
    }
    public void getMelon()
    {
        gameInfo.PlayerHPRemaining++;
        gameInfo.PlayerHPRemaining++;
    }
    public void getStrawberry()
    {
        gameInfo.PlayerHPRemaining++;
    }

    public void getCherry()
    {
        gameInfo.Heal(1);
        Debug.Log("You Got a Cherry");
    }

    public void getChicken()
    {
        gameInfo.HPUP();
        gameInfo.fullHeal();
        Debug.Log("You Got a Cherry");
    }

    public void halfspeed()
    {
        gameInfo.PlayerMS = gameInfo.PlayerMS/2;
        Debug.Log("You Got slowwwer");
    }

    public void doublespeed()
    {
        gameInfo.PlayerMS = gameInfo.PlayerMS*2;
        Debug.Log("You Got faster");
    }
    
    public void DMGUP()
    {
        gameInfo.PlayerDMG++;
        Debug.Log("You Got a DMGUP");
    }
    public void RangeUp()
    {
        gameInfo.PlayerRange++;
        Debug.Log("You Got a RangeUP");
    }

    public void halfjumpheight()
    {
        gameInfo.PlayerJumpHeight = gameInfo.PlayerJumpHeight/2;
    }

    public void doublejumpheight()
    {
        gameInfo.PlayerJumpHeight = gameInfo.PlayerJumpHeight*2;
    }

    public void JumpHeightUp()
    {
        gameInfo.PlayerJumpHeight += 1;
    }
    public void speedUp()
    {
        gameInfo.PlayerMS += 1;
    }   
    public void speedDown()
    {
        gameInfo.PlayerMS -= 1;
    }

    public void refreshJump()
    {
        doubleJump = true;
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
    private bool isGroundedTrap()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, jumpableGroundTrap);
    }


}