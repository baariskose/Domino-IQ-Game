using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public bool  moveLeft,moveRight,moveUp,moveDown,isFinal;
    public string name;
    GameObject button;
    Ball ball;
    // Start is called before the first frame update
    void Start()
    {
        isFinal = false;
        ball = GameObject.FindGameObjectWithTag("Ball").GetComponent<Ball>();
    }
    private void Update()
    {
        button = GameObject.FindGameObjectWithTag(name);
        if(button != null && name == button.GetComponent<PlatformController>().name && button.GetComponent<PlatformController>().isHit && isFinal == false && ball.currentTime <=0)
        {
            if (moveLeft)
            {
                MoveLeft();
            }
            else if (moveRight)
            {
                MoveRight();
            }
            else if (moveUp)
            {
                MoveUp();

            }
            else if (moveDown)
            {
                MoveDown();
            }
        }
       

    }
    public void MoveUp()
    {
        {

            transform.position += Vector3.up * Time.deltaTime / 2;

        }
    }
    public void MoveDown()
    {
        {

            transform.position += Vector3.down * Time.deltaTime / 1.5f;

        }
    }
    public void MoveRight()
    {
        {

            transform.position += Vector3.right * Time.deltaTime / 1.5f;

        }
    }
    public void MoveLeft()
    {
        {

            transform.position += Vector3.left * Time.deltaTime / 1.5f;

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
          
        if (collision.gameObject.tag == "Stone")
        {
          //  collision.gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
        }
    }
}
