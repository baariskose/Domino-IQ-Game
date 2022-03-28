using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatFormPositonController : MonoBehaviour
{
    Ball ball;
    GameController gameController;
    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.FindGameObjectWithTag("Ball").GetComponent<Ball>();
        gameController = GameObject.Find("Script").GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "MovePlatform" && ball.currentTime <=0)
        {
            collision.gameObject.GetComponent<Platform>().isFinal = true;
            gameController.gameOverTime = 10;
        }
    }
}
