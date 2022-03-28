using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SisenTop : MonoBehaviour
{
    bool isHit;
    Ball ball;
    GameController gameController;
    StoneTransferController transferController;
    GameObject selected;
    GameObject lastStone;
    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.FindGameObjectWithTag("Ball").GetComponent<Ball>();
        gameController = GameObject.Find("Script").GetComponent<GameController>();
        transferController = GameObject.Find("Script").GetComponent<StoneTransferController>();
        isHit = false;
        selected = transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (isHit && transform.localScale.x <= 0.778817f && ball.currentTime <= 0 )
        {
            transform.localScale += new Vector3(0.2f*Time.deltaTime, 0.2f * Time.deltaTime, 0);
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y+0.007f, 0);
        }
        if (gameObject.transform.position.y <= -3.67f)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, -3.609929f, 0);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Stone" || collision.gameObject.tag == "Ball" || collision.gameObject.tag == "Purple" )
        {
            if( ball.currentTime <= 0)
            {
                gameController.gameOverTime = 30;
                isHit = true;
            }
        }
        
    }
    private void OnMouseDown()
    {
        if (ball.currentTime >= 0)
        {

            selected.SetActive(true);
            if (transferController.currStone != null)
            {
                lastStone = transferController.currStone;
                Debug.Log("last" + lastStone.name);
                lastStone.transform.GetChild(0).gameObject.SetActive(false);
                if (lastStone == transferController.currStone)
                {
                    selected.SetActive(true);
                }

            }
            transferController.currStone = gameObject;
            Debug.Log("curr" + transferController.currStone.name);
        }

    }

}
