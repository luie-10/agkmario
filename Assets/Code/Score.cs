using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public int coin =0;
    public int score =0;
    public TMP_Text ScoreText;
    public TMP_Text CoinText;
    public GameObject PlayerOb;
    // Start is called before the first frame update
    void Start()
    {
       
    }
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        GameObject Score = GameObject.Find("Score");
        if (Score != null)
        {
            ScoreText = Score.GetComponent<TextMeshProUGUI>();
        }
        GameObject Coin = GameObject.Find("Coin");
        if (Coin != null)
        {
            CoinText = Coin.GetComponent<TextMeshProUGUI>();
        }
        GameObject Player = GameObject.Find("Player");
        if (Player != null)
        {
            PlayerOb = Player.GetComponent<GameObject>();
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        
        ScoreText.text = "MARIO \n" + score.ToString("D6");
        CoinText.text = "x " + coin.ToString("D2");
    }
}
