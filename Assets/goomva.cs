using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class goomva : MonoBehaviour
{
    public bool Right;
    public SpriteRenderer spriteRenderer;
    public float EnemySpeed;
    Animator anim;
    public Transform SpwanPoint;
    void Awake()
    {
        anim = GetComponent<Animator>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.CompareTag("Wall") || collision.collider.gameObject.CompareTag("Fipe"))
        {
            spriteRenderer.flipX = true;
            if (Right == false)
            {
                Right = true;
            }
            else
            {
                Right = false;
            }
        }
        if (collision.collider.gameObject.CompareTag("Player_Kill_enemy"))
        {
            anim.SetBool("Death", true);
            this.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            StartCoroutine("Dead");
        }
        if (collision.collider.gameObject.CompareTag("Player"))
        {
            collision.collider.gameObject.GetComponent<Animator>().SetTrigger("Death");
        }
    }
    void Update()
    {
        if (!Right)
        {
            this.transform.position = new Vector3(this.transform.position.x + EnemySpeed, transform.position.y, this.transform.position.z);
        }
        else if (Right)
        {
            this.transform.position = new Vector3(this.transform.position.x - EnemySpeed, transform.position.y, this.transform.position.z);
        }
    }
    public IEnumerator Dead()
    {
        yield return new WaitForSeconds(0.9f);
        Destroy(this);
        
        
    }
}
