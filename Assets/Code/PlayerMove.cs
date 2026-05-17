using Unity.VisualScripting;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float jumpPower;
    public float moveSpeed; // 이동 속도
    public bool isJumping;
    public SpriteRenderer spriteRenderer;

    Rigidbody2D rigid;
    
    Animator anim;

    public AudioSource jumpSound;
    public bool CanPlay;
    void Awake()
    {
        
        rigid = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();

        rigid.freezeRotation = true;
    }

    void Update()
    {
        // 1. 점프 로직
        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            rigid.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
            isJumping = true;
            jumpSound.Play();
           
            anim.SetBool("IsJumping", true);
        }

      if (CanPlay == true)
        {
            float h = Input.GetAxisRaw("Horizontal");


            rigid.velocity = new Vector2(h * moveSpeed, rigid.velocity.y);
            if (h != 0)
            {
                anim.SetBool("Walk", true);
                spriteRenderer.flipX = h < 0;
            }
            else if (h == 0)
            {
                anim.SetBool("Walk", false);
            }
        }



        
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor") || collision.gameObject.CompareTag("Fipe") || collision.gameObject.CompareTag("Coin Box"))


        {
            isJumping = false;
           
            anim.SetBool("IsJumping", false);
        }
    }
}