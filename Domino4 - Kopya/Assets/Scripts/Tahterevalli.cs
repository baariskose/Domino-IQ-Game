using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tahterevalli : MonoBehaviour
{
    // Start is called before the first frame update
    bool isHit;
    Ball ball;
    void Start()
    {
        isHit = false;
        ball = GameObject.FindGameObjectWithTag("Ball").GetComponent<Ball>();
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
        gameObject.GetComponent<Rigidbody2D>().freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(ball.currentTime <=0)
        {
            gameObject.GetComponent<BoxCollider2D>().enabled = true;
            gameObject.GetComponent<Rigidbody2D>().freezeRotation = false;
        }
        if(isHit)
        {
            transform.Rotate(0, 0, -1.5f * Time.deltaTime);

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "SpecialBall" || collision.gameObject.tag == "SpecialBall" || collision.gameObject.tag == "SpecialStone")
        {
            isHit = true;
        }
        if (collision.gameObject.tag == "Wall")
        {
            isHit = false;
            collision.gameObject.GetComponent<Rigidbody2D>().freezeRotation = true;
        }
    }
}
