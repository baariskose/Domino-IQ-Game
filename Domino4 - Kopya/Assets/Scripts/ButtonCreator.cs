using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCreator : MonoBehaviour
{
    public List<GameObject> buttons;
    public int buttonCount, i;
    Ball ball;
    StoneTransferController transferController;
    GameObject lastCerceve;
    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.FindGameObjectWithTag("Ball").GetComponent<Ball>();
        transferController = GameObject.Find("Script").GetComponent<StoneTransferController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateButton()
    {
        if(ball.currentTime >0 && buttonCount >0)
        {
            GameObject buttonC = Instantiate(buttons[i], gameObject.transform.position, Quaternion.identity);
            if(buttonC.gameObject.tag == "Gray" || buttonC.gameObject.tag == "Orange")
            {
                buttonC.gameObject.transform.Rotate(new Vector3(buttonC.transform.rotation.x, buttonC.transform.rotation.y, buttonC.transform.rotation.z + 90)); 
            }
            buttonCount--;
            i++;
            if (transferController.currStone != null)
            {
                Debug.Log("xxxxxxxx");
                lastCerceve = GameObject.FindGameObjectWithTag("cerceve");
                lastCerceve.SetActive(false);
            }

            transferController.currStone = buttonC;
            transferController.currStone.transform.GetChild(0).gameObject.SetActive(true);
        }
        
    }
}
