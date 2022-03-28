using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControl : MonoBehaviour
{
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
        selected = transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
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
