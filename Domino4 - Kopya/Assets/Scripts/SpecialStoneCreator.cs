using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialStoneCreator : MonoBehaviour
{
    // Start is called before the first frame update
    Ball ball;
    public GameObject[] specialStone;
    public int stoneCount;
    int i;
    StoneTransferController transferController;
    GameObject lastCerceve;
    void Start()
    {
        ball = GameObject.FindGameObjectWithTag("Ball").GetComponent<Ball>();
        transferController = GameObject.Find("Script").GetComponent<StoneTransferController>();
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void CreateSpecialStone()
    {

        if (stoneCount > 0 && ball.currentTime > 0)
        {
            GameObject ballC = Instantiate(specialStone[i], gameObject.transform.position, Quaternion.identity);
            ballC.GetComponent<Rigidbody2D>().gravityScale = 0;
            stoneCount--;
            i++;
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
