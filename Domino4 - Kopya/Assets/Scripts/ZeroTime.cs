using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeroTime : MonoBehaviour
{
    List<GameObject> balls;
    // Start is called before the first frame update1
    void Start()
    {
        balls = new List<GameObject>();
        
        balls.AddRange(GameObject.FindGameObjectsWithTag("Ball"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void makeZero()
    {
        foreach (var ball in balls)
        {
            ball.gameObject.GetComponent<Ball>().currentTime = 0;
        }
    }
}
