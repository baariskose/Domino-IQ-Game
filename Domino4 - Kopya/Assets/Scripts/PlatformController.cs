using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    public bool goLeft, goRight, goUp, goDown;
    public bool isHit;
    public string name;
    bool isHitOne;
    Ball ball;
    GameController gameController;
    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.FindGameObjectWithTag("Ball").GetComponent<Ball>();
        gameController = GameObject.Find("Script").GetComponent<GameController>();
        isHitOne = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(ball.currentTime <=0)
        {

        if (collision.gameObject.tag == "Ball" || collision.gameObject.tag == "Stone" || collision.gameObject.tag == "MovePlatform" || collision.gameObject.tag == "SpecialStoneLateral" || collision.gameObject.tag == "Pervane" || collision.gameObject.tag == "Baloon" || collision.gameObject.tag == "SpecialBall")
        {
            isHit = true;
             gameController.gameOverTime = 9;
           
                    if(goDown)
                    {
                        if (!isHitOne)
                        {
                            isHitOne = true;
                            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 0.2f, gameObject.transform.position.z);
                        }
                    }
                    else if(goUp)
                    {
                        if (!isHitOne)
                        {
                            isHitOne = true;
                            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 0.2f, gameObject.transform.position.z);
                        }

                    }
                    else if (goLeft)
                    {
                        if (!isHitOne)
                        {
                            isHitOne = true;
                            gameObject.transform.position = new Vector3(gameObject.transform.position.x - 0.2f, gameObject.transform.position.y, gameObject.transform.position.z);
                        }
                    }
                    else if (goRight)
                    {
                        if (!isHitOne)
                        {
                            isHitOne = true;
                            gameObject.transform.position = new Vector3(gameObject.transform.position.x + 0.2f, gameObject.transform.position.y, gameObject.transform.position.z);
                        }
                    }
         
        }
        }

    }
}
