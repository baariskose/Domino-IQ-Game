using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
    AudioSource audioSource;
    Ball ball;
    GameController gameController;
    StoneTransferController transferController;
    public AudioClip hitSound;
    bool isHit;
    GameObject selected;
    GameObject lastStone;
    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.FindGameObjectWithTag("Ball").GetComponent<Ball>();
        audioSource = GameObject.Find("Script").GetComponent<AudioSource>();
        gameController = GameObject.Find("Script").GetComponent<GameController>();
        transferController = GameObject.Find("Script").GetComponent<StoneTransferController>();
        selected = transform.GetChild(0).gameObject;

        isHit = false;
    }
    // Update is called once per frame
    void Update()
    {
       
         if(isHit)
        {
            if (gameController.gameOverTime <= 0)
            {
            }
        }
           
        
        if(gameObject.transform.position.y < -4.79f && ball.currentTime >=0)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, -2.5f, gameObject.transform.position.z);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(ball.currentTime <=0)
        {
            if (collision.gameObject.tag == "Ball" || collision.gameObject.tag == "Stone" || collision.gameObject.tag == "Pervane" || collision.gameObject.tag == "SpecialBall" || collision.gameObject.tag == "SpecialStone" || collision.gameObject.tag == "isinlanmaGiris" || collision.gameObject.tag == "isinlanmaCikis" || collision.gameObject.tag == "SpecialStoneLateral" || collision.gameObject.tag == "Blue" || collision.gameObject.tag == "Orange" || collision.gameObject.tag == "Purple" || collision.gameObject.tag == "Gray" || collision.gameObject.tag == "Wood")
            {
                gameController.gameOverTime = 5;
                isHit = true;
            }
            if (collision.gameObject.tag == "Stone")
            {
                audioSource.PlayOneShot(hitSound);
            }
        }
        
            
   
        
    }
    private void OnMouseDown()
    {
        if (ball.currentTime >= 0) {
     
            selected.SetActive(true);
           // lt null, 1,2,3 
           // cur 1 ,2,3,4
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
