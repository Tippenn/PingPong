using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        InvokeRepeating("tracking", 0f, 0.4f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void tracking()
    {
        if (ball.transform.position.y > rb.transform.position.y + 0.5)
        {
            rb.velocity = (new Vector2(0, 5f));
        }
        else if (ball.transform.position.y < rb.transform.position.y - 0.5)
        {
            rb.velocity = (new Vector2(0, -5f));
        }
    }
}
