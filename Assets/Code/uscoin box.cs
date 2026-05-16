using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class  UseCoinox : MonoBehaviour
{
    public Sprite Chagebox;
   
    public GameObject coin;
    public float Num;
    public SpriteRenderer Box;
    public bool on = false;
    private int count = 0;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (on == false)
        {
            if (collision.collider.gameObject.CompareTag("Player_Coin_Box"))
            {

                Box.sprite = Chagebox;
                InvokeRepeating(nameof(up), 1f, 0.1f);
                InvokeRepeating("down", 1f, 0.1f);
                on = true;
                
            }
        }
        
    }
    void up()
    {
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + Num, this.transform.position.z);
        Debug.Log("up");
        count += 1;
    }
    void down()
    {
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y - Num, this.transform.position.z);
        Debug.Log("down");
        count += 1;
    }

    void Update()
    {
        if (count >= 5)
        {
            CancelInvoke("up");
            
        }
        if (count >= 10 )
        {
            CancelInvoke("down");
        }
    }
} 

    

