using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameramove : MonoBehaviour
{
    public GameObject player;
    public float CameraSpeed =0.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        
        if (this.transform.position.x < player.transform.position.x)
        {
            
            this.transform.position = new Vector3(this.transform.position.x + CameraSpeed,transform.position.y,-10);
        }
        else if (this.transform.position.x > player.transform.position.x)
        {
            this.transform.position = new Vector3(this.transform.position.x - CameraSpeed, transform.position.y, -10);
        }
        else
        {

        }
    }
}
