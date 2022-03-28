using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Slot : MonoBehaviour
{
    StoneTransferController transferController;
    public bool isLeftSide;
    public bool isRightSide;
    bool isEmpty;
    Ball ball;
    // Start is called before the first frame update
    void Start()
    {
        transferController = GameObject.Find("Script").GetComponent<StoneTransferController>();
        isEmpty = true;
        ball = GameObject.FindGameObjectWithTag("Ball").GetComponent<Ball>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ball.currentTime <= 0)
        {
            gameObject.SetActive(false);
        }
    }
    private void OnMouseDown()
    {
        if (ball.currentTime >= 0)
        {
            if (isEmpty && transferController.currStone != null)
            {
                if (isLeftSide)
                {
                    transferController.currStone.transform.position = new Vector3(gameObject.transform.position.x - 0.23f, gameObject.transform.position.y + 1, gameObject.transform.position.z);
                    transferController.currStone.transform.GetChild(0).gameObject.SetActive(false);
            
                }
                else if (isRightSide)
                {
                    transferController.currStone.transform.position = new Vector3(gameObject.transform.position.x + 0.23f, gameObject.transform.position.y + 1, gameObject.transform.position.z);
                    transferController.currStone.transform.GetChild(0).gameObject.SetActive(false);

                }
                else
                {
                    if(transferController.currStone.tag == "SpecialStoneLateral")
                    {
                        transferController.currStone.transform.position = new Vector3(gameObject.transform.position.x-1f, gameObject.transform.position.y+ 0.4f, gameObject.transform.position.z);
                        transferController.currStone.transform.GetChild(0).gameObject.SetActive(false);
                        Debug.Log("asd");
                    }
                    else if (transferController.currStone.tag=="Gray" )
                    {
                        if (SceneManager.GetActiveScene().buildIndex == 60)
                        {
                            Debug.Log("aasfv");
                            transferController.currStone.transform.position = new Vector3(-0.76f, 1.74f, gameObject.transform.position.z);
                            transferController.currStone.transform.GetChild(0).gameObject.SetActive(false);
                        }
                        else if (SceneManager.GetActiveScene().buildIndex == 61)
                        {
                            Debug.Log("aasfv");
                            transferController.currStone.transform.position = new Vector3(gameObject.transform.position.x-0.5f, gameObject.transform.position.y, gameObject.transform.position.z);
                            transferController.currStone.transform.GetChild(0).gameObject.SetActive(false);
                        }
                        else
                        {
                            transferController.currStone.transform.position = new Vector3(gameObject.transform.position.x + 0.23f, gameObject.transform.position.y + 0.5f, gameObject.transform.position.z);
                            transferController.currStone.transform.GetChild(0).gameObject.SetActive(false);

                        }
                       
                    }
                    else if( transferController.currStone.tag == "Blue"  )
                    {
                        if(SceneManager.GetActiveScene().buildIndex == 59)
                        {
                            transferController.currStone.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
                            transferController.currStone.transform.GetChild(0).gameObject.SetActive(false);
                        }
                        else if (SceneManager.GetActiveScene().buildIndex == 61)
                        {
                            transferController.currStone.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y+0.3f, gameObject.transform.position.z);
                            transferController.currStone.transform.GetChild(0).gameObject.SetActive(false);
                        }
                        else
                        {
                            transferController.currStone.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 0.5f, gameObject.transform.position.z);
                            transferController.currStone.transform.GetChild(0).gameObject.SetActive(false);
                        }
                      
                    }
                    else if(transferController.currStone.tag == "Purple")
                    {
                         if (SceneManager.GetActiveScene().buildIndex == 61)
                        {
                            Debug.Log("aasfv");
                            transferController.currStone.transform.position = new Vector3(gameObject.transform.position.x , gameObject.transform.position.y-0.4f, gameObject.transform.position.z);
                            transferController.currStone.transform.GetChild(0).gameObject.SetActive(false);
                        }
                        else
                        {
                            transferController.currStone.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 0.5f, gameObject.transform.position.z);
                            transferController.currStone.transform.GetChild(0).gameObject.SetActive(false);
                        }
                       
                    }
                    else if (transferController.currStone.tag == "Green")
                    {
                        if (SceneManager.GetActiveScene().buildIndex == 61)
                        {
                            Debug.Log("aasfv");
                            transferController.currStone.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 0.35f, gameObject.transform.position.z);
                            transferController.currStone.transform.GetChild(0).gameObject.SetActive(false);
                        }
                        else
                        {
                            transferController.currStone.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 0.5f, gameObject.transform.position.z);
                            transferController.currStone.transform.GetChild(0).gameObject.SetActive(false);
                        }
                      
                    }
                    else if (transferController.currStone.tag == "Orange")
                    {
                        if (SceneManager.GetActiveScene().buildIndex == 61)
                        {
                            Debug.Log("aasfv");
                            transferController.currStone.transform.position = new Vector3(gameObject.transform.position.x-0.1f, gameObject.transform.position.y +1.3f, gameObject.transform.position.z);
                            transferController.currStone.transform.GetChild(0).gameObject.SetActive(false);
                        }
                        

                    }
                    else
                    {
                        transferController.currStone.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 1.5f, gameObject.transform.position.z);
                        transferController.currStone.transform.GetChild(0).gameObject.SetActive(false);
                    }
                   

                }
                transferController.currStone.GetComponent<Rigidbody2D>().gravityScale = 1;
                transferController.currStone = null;
            }

        }
     
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Stone" || collision.gameObject.tag == "SpecialStoneLateral" || collision.gameObject.tag == "SpecialStone" || collision.gameObject.tag == "Blue" || collision.gameObject.tag == "Purple" || collision.gameObject.tag == "Green"|| collision.gameObject.tag == "Gray"|| collision.gameObject.tag == "SpecialBall")
        {
            isEmpty = false;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Stone" || collision.gameObject.tag == "SpecialStoneLateral" || collision.gameObject.tag == "SpecialStone" || collision.gameObject.tag == "Blue" || collision.gameObject.tag == "Purple" || collision.gameObject.tag == "Green" || collision.gameObject.tag == "Gray" || collision.gameObject.tag == "SpecialBall")
        {
            isEmpty = false;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Stone" || collision.gameObject.tag == "SpecialStoneLateral" || collision.gameObject.tag == "SpecialStone" || collision.gameObject.tag == "Blue" || collision.gameObject.tag == "Purple" || collision.gameObject.tag == "Green" || collision.gameObject.tag == "Gray" || collision.gameObject.tag == "SpecialBall")
        {
            isEmpty = true;
        }
    }
}
