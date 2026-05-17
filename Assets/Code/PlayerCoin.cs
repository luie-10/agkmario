using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerEat : MonoBehaviour
{
    public GameObject Ui;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        
         if (collision.collider.gameObject.CompareTag("Coin"))
         {
            Destroy(collision.gameObject);
            Ui.GetComponent<Score>().coin += 1;
            Ui.GetComponent<Score>().score += 200;
                





         }

        if (collision.collider.gameObject.CompareTag("Mush"))
        {
            for (int i = 0; i < 10; i++)
            {
                this.GetComponent<Transform>().localScale = new Vector3(this.transform.localScale.x + 0.01f, this.transform.localScale.y + 0.01f, this.transform.localScale.z);
            }
            
             





        }


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
