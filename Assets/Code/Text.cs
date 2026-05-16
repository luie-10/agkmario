using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Text : MonoBehaviour
{
    public TMP_Text timetext;

    public float setTime = 400;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        setTime -= Time.deltaTime;
        timetext.text = "Time\n" + setTime.ToString("F0") ;
        
    }
}
