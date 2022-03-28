using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public float startTime,currentTime;
    public float gravity;
    GameController gameController;
    public Text time;
    // Start is called before the first frame update
    void Start()
    {
        time.text = startTime.ToString("0"); ;
        currentTime = startTime;
        gameController = GameObject.Find("Script").GetComponent<GameController>();
        gameObject.GetComponent<CircleCollider2D>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;
        time.text = currentTime.ToString("0");
        if(currentTime <= 0)
        {
            gameController.isGameStart = true;
            gameObject.GetComponent<Rigidbody2D>().gravityScale = gravity;
            gameObject.GetComponent<CircleCollider2D>().enabled = true;
            time.text = 0.ToString();
        }
    }
}
