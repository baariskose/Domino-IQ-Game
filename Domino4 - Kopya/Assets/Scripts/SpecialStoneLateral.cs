using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialStoneLateral : MonoBehaviour
{
    bool isHit;
    Ball ball;
    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.FindGameObjectWithTag("Ball").GetComponent<Ball>();
        gameObject.GetComponent<Rigidbody2D>().freezeRotation = true;

        gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
        isHit = false;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Rigidbody2D>().freezeRotation = true;

        if (isHit && ball.currentTime <= 0 && transform.localScale.x < 0.6377338f)
        {
            transform.localScale += new Vector3(0.1f * Time.deltaTime, 0, 0);

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        
        if (collision.gameObject.tag == "Stone" || collision.gameObject.tag == "Ball" || collision.gameObject.tag == "SpecialStone" || collision.gameObject.tag == "Pervane" || collision.gameObject.tag == "Baloon") 
        {
            if(collision.gameObject.tag == "Stone")
            {
                collision.gameObject.GetComponent<Rigidbody2D>().mass = 5;
            }
            if (ball.currentTime <= 0)
            {
                isHit = true;

            }
        }
        else if (collision.gameObject.tag == "Wood")
        {
            isHit = false;
        }
    }
}
