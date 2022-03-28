using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LateralStoneCreator : MonoBehaviour
{
    // Start is called before the first frame update
    Ball ball;
    public GameObject specialStone;
    public int stoneCount;
    void Start()
    {
        ball = GameObject.FindGameObjectWithTag("Ball").GetComponent<Ball>();
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void CreateLateralStone()
    {

        if (stoneCount > 0 && ball.currentTime > 0)
        {
            GameObject ballC = Instantiate(specialStone, gameObject.transform.position, Quaternion.identity);
            ballC.GetComponent<Rigidbody2D>().gravityScale = 0;
            stoneCount--;
        }

    }
}
