using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    // Start is called before the first frame update

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        float rand = 0;
        do
        {
            rand = Random.Range(-1, 2);
            Debug.Log(rand);
        } while (rand < 0.5 && rand > -0.5);
        
        rb.AddForce(new Vector2(rand*speed*10, rand*speed*5));
    }

    void BallStart()
    {
        float rand = 0;
        do
        {
            rand = Random.Range(-1, 2);
            Debug.Log(rand);
        } while (rand < 0.5 && rand > -0.5);

        rb.AddForce(new Vector2(rand * speed * 10, rand * speed * 5));
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.collider.CompareTag("Player"))
        {
            Vector2 vel;
            vel.x = rb.velocity.x ;
            vel.y = (rb.velocity.y/2) + (coll.collider.attachedRigidbody.velocity.y / 3);
            rb.velocity = vel;
        }
    }
}
