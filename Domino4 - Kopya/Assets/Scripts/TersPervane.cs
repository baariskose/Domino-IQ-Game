using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TersPervane : MonoBehaviour
{
    // Start is called before the first frame update
    bool isHit, isHitWall;
    Ball ball;
    void Start()
    {
        isHit = false;
        isHitWall = false;
        ball = GameObject.FindGameObjectWithTag("Ball").GetComponent<Ball>();
        gameObject.GetComponent<PolygonCollider2D>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isHit && !isHitWall)
        {
            //transform.Rotate(0, 0, 1.5f);
        }
        if (ball.currentTime <= 0)
        {
            gameObject.GetComponent<PolygonCollider2D>().enabled = true;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (ball.currentTime <= 0)
        {
           
            if (collision.gameObject.tag == "Stone" || collision.gameObject.tag == "Pervane")
            {
                isHit = true;
            }
            if (collision.gameObject.tag == "Wall")
            {
                isHitWall = true;
            }
        }

    }
}
