using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DontPut : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource audioSource;
    public AudioClip failSong;
    GameObject script;
    public Text warningText ;
    void Start()
    {
        audioSource = GameObject.Find("Script").GetComponent<AudioSource>();
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
        if (collision.gameObject.tag == "Orange" || collision.gameObject.tag == "Purple" || collision.gameObject.tag == "Gray" || collision.gameObject.tag == "Blue" || collision.gameObject.tag == "Green")
        {
           
            // audioSource.PlayOneShot(failSong);
            collision.gameObject.transform.position = new Vector2(script.gameObject.transform.position.x, script.gameObject.transform.position.y);
            warningText.GetComponent<Text>().color = new Color(255, 0, 0, 255);
            warningText.text = "You can not put it there. Try any other options.";
            
           
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
