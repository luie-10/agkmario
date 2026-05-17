using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Text : MonoBehaviour
{
    public TMP_Text timetext;

    public float setTime = 400;
    // Start is called before the first frame update
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        GameObject Time = GameObject.Find("Time");
        if (Time != null)
        {
            timetext = Time.GetComponent<TextMeshProUGUI>();
        }
    }
        // Update is called once per frame
        void Update()
    {

        setTime -= Time.deltaTime;
        timetext.text = "Time\n" + setTime.ToString("F0") ;

        
    }
}
