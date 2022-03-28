using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPermission : MonoBehaviour
{
    public string buttonName;
    public Text warningText;
    GameObject script;
    // Start is called before the first frame update
    void Start()
    {
        script = GameObject.Find("Script");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(buttonName != collision.gameObject.tag)
        {
            if(collision.gameObject.tag == "Purple" || collision.gameObject.tag == "Green" || collision.gameObject.tag == "Gray"|| collision.gameObject.tag == "Orange"|| collision.gameObject.tag == "Blue")
            {
                collision.gameObject.transform.position = new Vector2(script.gameObject.transform.position.x, script.gameObject.transform.position.y);
                warningText.GetComponent<Text>().color = new Color(255, 0, 0, 255);
                warningText.text = "You can not put it there. Try any other options.";
            }
           
        }
       
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Invoke("DestroyText", 5);
    }

    public void DestroyText()
    {
        warningText.GetComponent<Text>().color = new Color(0, 0, 0, 0);
    }
}
