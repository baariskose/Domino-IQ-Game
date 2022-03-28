using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StoneCreator : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> stones;
    public Text stoneText;
    public bool isClickButton;
    Scene scene;
    Ball ball;
    public int stoneCount;
    int i;
    StoneTransferController transferController;
    GameObject lastCerceve;
    void Start()
    {
        ball = GameObject.FindGameObjectWithTag("Ball").GetComponent<Ball>();
        scene = SceneManager.GetActiveScene();
        i = 0;
        stoneText.text = stoneCount.ToString();
        transferController = GameObject.Find("Script").GetComponent<StoneTransferController>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CreateStone()
    {
        isClickButton = true;
        if(ball.currentTime >0 && stoneCount > 0) {
            if (scene.buildIndex == 7 || scene.buildIndex == 8 || scene.buildIndex == 9 || scene.buildIndex == 10 || scene.buildIndex == 16)
            {

                GameObject stoneC = Instantiate(stones[i], transform.position, Quaternion.identity);
                stoneC.GetComponent<Rigidbody2D>().gravityScale = 0;
                stoneCount--;
                stoneText.text = stoneCount.ToString();
                i++;
                stoneC.transform.GetChild(0).gameObject.SetActive(true);

                if (transferController.currStone != null)
                {
                    lastCerceve = GameObject.FindGameObjectWithTag("cerceve");
                    lastCerceve.SetActive(false);
                }
                    
                transferController.currStone = stoneC;
                transferController.currStone.transform.GetChild(0).gameObject.SetActive(true);


            }
           else if (scene.buildIndex == 18)
            {
                
                if(i<3)
                {
                  
                    GameObject stoneC = Instantiate(stones[i], transform.position, Quaternion.identity);
                    stoneC.GetComponent<Rigidbody2D>().gravityScale = 0;
                    stoneCount--;
                    stoneText.text = stoneCount.ToString();
                    i++;
                    lastCerceve = GameObject.FindGameObjectWithTag("cerceve");
                    if(lastCerceve != null)
                        lastCerceve.SetActive(false);
                    stoneC.transform.GetChild(0).gameObject.SetActive(true);
                    transferController.currStone = stoneC;
                    transferController.currStone.transform.GetChild(0).gameObject.SetActive(true);
                }
                else
                {
                    GameObject stoneC = Instantiate(stones[Random.Range(3, 7)], transform.position, Quaternion.identity);
                    stoneC.GetComponent<Rigidbody2D>().gravityScale = 0;
                    stoneCount--;
                    stoneText.text = stoneCount.ToString();
                    stoneC.transform.GetChild(0).gameObject.SetActive(true);
                    lastCerceve = GameObject.FindGameObjectWithTag("cerceve");
                    lastCerceve.SetActive(false);
                    transferController.currStone = stoneC;
                    transferController.currStone.transform.GetChild(0).gameObject.SetActive(true);
                }
         
            }
            else if(scene.buildIndex == 19)
            {
                if (i < 3)
                {

                    GameObject stoneC = Instantiate(stones[i], transform.position, Quaternion.identity);
                    stoneC.GetComponent<Rigidbody2D>().gravityScale = 0;
                    stoneCount--;
                    stoneText.text = stoneCount.ToString();
                    i++;
                    stoneC.transform.GetChild(0).gameObject.SetActive(true);
                    lastCerceve = GameObject.FindGameObjectWithTag("cerceve");
                    lastCerceve.SetActive(false);
                    transferController.currStone = stoneC;
                    transferController.currStone.transform.GetChild(0).gameObject.SetActive(true);
                }
                else
                {
                    GameObject stoneC = Instantiate(stones[Random.Range(3, 7)], transform.position, Quaternion.identity);
                    stoneC.GetComponent<Rigidbody2D>().gravityScale = 0;
                    stoneCount--;
                    stoneC.transform.GetChild(0).gameObject.SetActive(true);
                    lastCerceve = GameObject.FindGameObjectWithTag("cerceve");
                    lastCerceve.SetActive(false);
                    stoneText.text = stoneCount.ToString();
                    transferController.currStone = stoneC;
                    transferController.currStone.transform.GetChild(0).gameObject.SetActive(true);
                }
            }
            else if (scene.buildIndex == 33)
            {
                if (i < 2)
                {

                    GameObject stoneC = Instantiate(stones[i], transform.position, Quaternion.identity);
                    stoneC.GetComponent<Rigidbody2D>().gravityScale = 0;
                    stoneCount--;
                    stoneText.text = stoneCount.ToString();
                    i++;
                    stoneC.transform.GetChild(0).gameObject.SetActive(true);
                    lastCerceve = GameObject.FindGameObjectWithTag("cerceve");
                    lastCerceve.SetActive(false);
                    transferController.currStone = stoneC;
                    transferController.currStone.transform.GetChild(0).gameObject.SetActive(true);
                }
                else
                {
                    GameObject stoneC = Instantiate(stones[Random.Range(2, 7)], transform.position, Quaternion.identity);
                    stoneC.GetComponent<Rigidbody2D>().gravityScale = 0;
                    stoneCount--;
                    stoneText.text = stoneCount.ToString();
                    stoneC.transform.GetChild(0).gameObject.SetActive(true);
                    lastCerceve = GameObject.FindGameObjectWithTag("cerceve");
                    lastCerceve.SetActive(false);
                    transferController.currStone = stoneC;
                    transferController.currStone.transform.GetChild(0).gameObject.SetActive(true);
                }
            }
            else if (scene.buildIndex == 37)
            {
                if (i < 3)
                {

                    GameObject stoneC = Instantiate(stones[i], transform.position, Quaternion.identity);
                    stoneC.GetComponent<Rigidbody2D>().gravityScale = 0;
                    stoneCount--;
                    stoneText.text = stoneCount.ToString();
                    i++;
                    stoneC.transform.GetChild(0).gameObject.SetActive(true);
                    lastCerceve = GameObject.FindGameObjectWithTag("cerceve");
                    lastCerceve.SetActive(false);
                    transferController.currStone = stoneC;
                    transferController.currStone.transform.GetChild(0).gameObject.SetActive(true);
                }
                else
                {
                    GameObject stoneC = Instantiate(stones[Random.Range(3, 8)], transform.position, Quaternion.identity);
                    stoneC.GetComponent<Rigidbody2D>().gravityScale = 0;
                    stoneCount--;
                    stoneText.text = stoneCount.ToString();
                    stoneC.transform.GetChild(0).gameObject.SetActive(true);
                    lastCerceve = GameObject.FindGameObjectWithTag("cerceve");
                    lastCerceve.SetActive(false);
                    transferController.currStone = stoneC;
                    transferController.currStone.transform.GetChild(0).gameObject.SetActive(true);
                }
            }
            else if (scene.buildIndex == 39)
            {
                if (i < 2)
                {

                    GameObject stoneC = Instantiate(stones[i], transform.position, Quaternion.identity);
                    stoneC.GetComponent<Rigidbody2D>().gravityScale = 0;
                    stoneCount--;
                    stoneText.text = stoneCount.ToString();
                    i++;
                    stoneC.transform.GetChild(0).gameObject.SetActive(true);
                    lastCerceve = GameObject.FindGameObjectWithTag("cerceve");
                    lastCerceve.SetActive(false);
                    transferController.currStone = stoneC;
                    transferController.currStone.transform.GetChild(0).gameObject.SetActive(true);
                }
                else
                {
                    GameObject stoneC = Instantiate(stones[Random.Range(2, 7)], transform.position, Quaternion.identity);
                    stoneC.GetComponent<Rigidbody2D>().gravityScale = 0;
                    stoneCount--;
                    stoneText.text = stoneCount.ToString();
                    stoneC.transform.GetChild(0).gameObject.SetActive(true);
                    lastCerceve = GameObject.FindGameObjectWithTag("cerceve");
                    lastCerceve.SetActive(false);
                    transferController.currStone = stoneC;
                    transferController.currStone.transform.GetChild(0).gameObject.SetActive(true);
                }
            }
            else if (scene.buildIndex == 43)
            {
                if (i < 4)
                {

                    GameObject stoneC = Instantiate(stones[i], transform.position, Quaternion.identity);
                    stoneC.GetComponent<Rigidbody2D>().gravityScale = 0;
                    stoneCount--;
                    stoneText.text = stoneCount.ToString();
                    i++;
                    stoneC.transform.GetChild(0).gameObject.SetActive(true);
                    lastCerceve = GameObject.FindGameObjectWithTag("cerceve");
                    lastCerceve.SetActive(false);
                    transferController.currStone = stoneC;
                    transferController.currStone.transform.GetChild(0).gameObject.SetActive(true);
                }
                else
                {
                    GameObject stoneC = Instantiate(stones[Random.Range(4, 10)], transform.position, Quaternion.identity);
                    stoneC.GetComponent<Rigidbody2D>().gravityScale = 0;
                    stoneCount--;
                    stoneText.text = stoneCount.ToString();
                    stoneC.transform.GetChild(0).gameObject.SetActive(true);
                    lastCerceve = GameObject.FindGameObjectWithTag("cerceve");
                    lastCerceve.SetActive(false);
                    transferController.currStone = stoneC;
                    transferController.currStone.transform.GetChild(0).gameObject.SetActive(true);
                }
            }
            else if (scene.buildIndex == 20)
            {
                if (i < 3)
                {

                    GameObject stoneC = Instantiate(stones[i], transform.position, Quaternion.identity);
                    stoneC.GetComponent<Rigidbody2D>().gravityScale = 0;
                    stoneCount--;
                    stoneText.text = stoneCount.ToString();
                    i++;
                    stoneC.transform.GetChild(0).gameObject.SetActive(true);
                    lastCerceve = GameObject.FindGameObjectWithTag("cerceve");
                    lastCerceve.SetActive(false);
                    transferController.currStone = stoneC;
                    transferController.currStone.transform.GetChild(0).gameObject.SetActive(true);
                }
                else
                {
                    GameObject stoneC = Instantiate(stones[Random.Range(3, 8)], transform.position, Quaternion.identity);
                    stoneC.GetComponent<Rigidbody2D>().gravityScale = 0;
                    stoneCount--;
                    stoneText.text = stoneCount.ToString();
                    stoneC.transform.GetChild(0).gameObject.SetActive(true);
                    lastCerceve = GameObject.FindGameObjectWithTag("cerceve");
                    lastCerceve.SetActive(false);
                    transferController.currStone = stoneC;
                    transferController.currStone.transform.GetChild(0).gameObject.SetActive(true);
                }
            }
            else
            {
                if (stoneCount > 0 && ball.currentTime > 0)
                {
                    GameObject stoneC = Instantiate(stones[Random.Range(0, 5)], transform.position, Quaternion.identity);
                    stoneC.GetComponent<Rigidbody2D>().gravityScale = 0;
                    stoneCount--;
                    stoneText.text = stoneCount.ToString();
                    stoneC.transform.GetChild(0).gameObject.SetActive(true);
                    lastCerceve = GameObject.FindGameObjectWithTag("cerceve");
                    lastCerceve.SetActive(false);
                    transferController.currStone = stoneC;
                    transferController.currStone.transform.GetChild(0).gameObject.SetActive(true);

                }
            }
        }
       
       
        
        
    }
    public void CreateStoneForSpecial()
    {
        if (i < 2)
        {

            GameObject stoneC = Instantiate(stones[i], transform.position, Quaternion.identity);
            stoneC.GetComponent<Rigidbody2D>().gravityScale = 0;
            stoneCount--;
            stoneText.text = stoneCount.ToString();
            i++;
        }
        else
        {
            GameObject stoneC = Instantiate(stones[Random.Range(2, 7)], transform.position, Quaternion.identity);
            stoneC.GetComponent<Rigidbody2D>().gravityScale = 0;
            stoneCount--;
            stoneText.text = stoneCount.ToString();
        }
    }
}
