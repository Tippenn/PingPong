using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GoalBehaviour : MonoBehaviour
{
    public GameObject ball;
    public int sides;
    private Vector2 position;
    // Start is called before the first frame update
    void Start()
    {
        position = ball.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        ball.transform.position = position;
        if(sides == 1)
        {
            ScoreBehaviour.instance.Increase_LScore(1);
        }
        else
        {
            ScoreBehaviour.instance.Increase_RScore(1);
        }
    }
}
