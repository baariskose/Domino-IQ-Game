using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    Vector3 objectPosition;
    Ball ball;

    private void Start()
    {
        ball = GameObject.FindGameObjectWithTag("Ball").GetComponent<Ball>();
    }
    private void Update()
    {
        if (ball.currentTime <= 0)
        {
            if(gameObject.tag == "SpecialStone" || gameObject.tag == "SpecialStoneLateral" || gameObject.tag == "Purple" || gameObject.tag == "Blue" || gameObject.tag == "Gray" || gameObject.tag == "Green" || gameObject.tag == "Orange")
            {
                gameObject.GetComponent<Rigidbody2D>().freezeRotation = true;
            }
            else
            {
                gameObject.GetComponent<Rigidbody2D>().freezeRotation = false;
            }
        }
    }
    void OnMouseDown()
    {
        if(ball.currentTime>0)
        {
           // gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;
            gameObject.GetComponent<Rigidbody2D>().freezeRotation = true;
            if(gameObject.tag == "Stone")
            {
              //  gameObject.GetComponent<BoxCollider2D>().enabled = false;
                

            }
            else if(gameObject.tag == "SpecialBall")
            {
               // gameObject.GetComponent<CircleCollider2D>().enabled = false;
            }
            else if (gameObject.tag == "SpecialStoneLateral")
            {
                gameObject.GetComponent<BoxCollider2D>().enabled = false;
            }
            else if (gameObject.tag == "SpecialStone" || gameObject.tag == "Purple" || gameObject.tag == "Blue" || gameObject.tag == "Gray" || gameObject.tag == "Green" || gameObject.tag == "Orange")
            {
                gameObject.GetComponent<BoxCollider2D>().enabled = false;
            }
            objectPosition = Camera.main.WorldToScreenPoint(transform.position);
        }
      
    }
     void OnMouseDrag()
    {
        if (ball.currentTime > 0)
        {
           // Vector3 pos = new Vector3(Input.mousePosition.x-100, Input.mousePosition.y+90, objectPosition.z);
            //Vector3 pos = new Vector3(Input.mousePosition.x , Input.mousePosition.y, objectPosition.z);
            //transform.position = Camera.main.ScreenToWorldPoint(pos);
        }
      
    }
    private void OnMouseUp()
    {
        if (ball.currentTime > 0)
        {
           
            if (gameObject.tag == "Stone")
            {
            gameObject.GetComponent<BoxCollider2D>().enabled = true;
                
            }
            else if (gameObject.tag == "SpecialBall")
            {
                gameObject.GetComponent<CircleCollider2D>().enabled = true;
                gameObject.GetComponent<Rigidbody2D>().freezeRotation = true;
            }
            else if (gameObject.tag == "SpecialStoneLateral")
            {
                gameObject.GetComponent<BoxCollider2D>().enabled = true;
            }
            else if (gameObject.tag == "SpecialStone" || gameObject.tag == "Purple" || gameObject.tag == "Blue" || gameObject.tag == "Gray" || gameObject.tag == "Green" || gameObject.tag == "Orange")
            {
                gameObject.GetComponent<BoxCollider2D>().enabled = true;
            }
        }
            
    }
}
