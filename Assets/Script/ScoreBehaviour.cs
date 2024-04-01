using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreBehaviour : MonoBehaviour
{   
    public static ScoreBehaviour instance;

    public TMP_Text scoretext;
    private int Lscore = 0;
    private int Rscore = 0;
    // Start is called before the first frame update

    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        scoretext.text = Lscore.ToString() +"    "+ Rscore.ToString();
    }
    private void Scorecheck()
    {
        if (Lscore > 2)
        {
            Debug.Log("Lu menang nub");
            this.gameObject.SendMessage("ChangeScene","Main Menu");
        }

        if (Rscore > 2)
        {
            Debug.Log("Lu kalah nub");
            this.gameObject.SendMessage("ChangeScene","Main Menu");
        }
    }
    // Update is called once per frame
    public void Increase_LScore(int Score)
    {
        Lscore += Score;
        scoretext.text = Lscore.ToString() + "    " + Rscore.ToString();
        Scorecheck();
    }

    public void Increase_RScore(int Score)
    {
        Rscore += Score;
        scoretext.text = Lscore.ToString() + "    " + Rscore.ToString();
        Scorecheck();
    }
}
