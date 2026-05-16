using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fife : MonoBehaviour
{
    public GameObject player;
    public Sprite sprite;
    public SpriteRenderer spriteRenderer;
    public float Num;
    public int count = 0;
    public GameObject Pife;
    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.collider.gameObject.CompareTag("Player_Kill_enemy"))
        {
            if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S) )
            {
                player.GetComponent<Animator>().enabled = false;
                player.GetComponent<SpriteRenderer>().sprite = sprite;
                player.GetComponent<PlayerJump>().CanPlay = false;
                player.GetComponent<BoxCollider2D>().enabled = false;
                player.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
                Pife.GetComponent<BoxCollider2D>().enabled = false;
                InvokeRepeating("rate", 1f, 0.2f);
            }
            
            
        }
    }
    void rate()
    {
        player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y - Num, player.transform.position.z);
        count += 1;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (count >= 5)
        {
            CancelInvoke("rate");
        }
    }
}
