using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialStone : MonoBehaviour
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

        if (isHit && ball.currentTime <= 0)
        {
            transform.localScale += new Vector3(0, 0.2f * Time.deltaTime,0);


        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Stone" && ball.currentTime >0) {
            //Destroy(collision.gameObject);
        }
        if(collision.gameObject.tag == "Stone" || collision.gameObject.tag == "Ball")
        {
            if (  ball.currentTime <= 0)
            {
                isHit = true;

            }
        }
        else if(collision.gameObject.tag == "Wood" || collision.gameObject.tag == "SpecialStoneLateral" || collision.gameObject.tag == "Pervane")
        {
            isHit = false;
        }
    }
}
