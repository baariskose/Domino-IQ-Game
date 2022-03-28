using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialBallCreator : MonoBehaviour
{
    public GameObject specialBall;
    public int ballCount;
    Ball ball;
    GameObject lastCerceve;
    StoneTransferController transferController;
    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.FindGameObjectWithTag("Ball").GetComponent<Ball>();
        transferController = GameObject.Find("Script").GetComponent<StoneTransferController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CreateSpecialBall()
    {

        if(ballCount >0 && ball.currentTime >0)
        {
            GameObject ballC = Instantiate(specialBall, gameObject.transform.position, Quaternion.identity);
            ballC.GetComponent<Rigidbody2D>().gravityScale = 0;
            ballCount--;

            ballC.transform.GetChild(0).gameObject.SetActive(true);
            if (transferController.currStone != null)
            {
                lastCerceve = GameObject.FindGameObjectWithTag("cerceve");
                lastCerceve.SetActive(false);
            }
            transferController.currStone = ballC;
            transferController.currStone.transform.GetChild(0).gameObject.SetActive(true);
        }
        
    }
}
