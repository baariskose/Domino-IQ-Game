using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialPervane : MonoBehaviour
{
    Ball ball;
    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.Find("ball").GetComponent<Ball>();
    }

    // Update is called once per frame
    void Update()
    {
       
        if(ball.currentTime <=0)
        {
            transform.Rotate(0, 0, 1.5f);
        }

    }
}
