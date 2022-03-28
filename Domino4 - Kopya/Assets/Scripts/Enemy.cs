using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public bool stoneIsHit;
    public GameObject bayilmaAnim;
    GameController gameController;
     AudioSource audioSource;
    public AudioClip hitSound;
    void Start()
    {
        stoneIsHit = false;
        gameController = GameObject.Find("Script").GetComponent<GameController>();
        audioSource = GameObject.Find("Script").GetComponent<AudioSource>();
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        if (collision.gameObject.tag == "Stone" || collision.gameObject.tag == "Ball" || collision.gameObject.tag == "SpecialBall")
        {
            if(gameController.isGameStart == true)
            {
                stoneIsHit = true;
                GameObject bayilma = Instantiate(bayilmaAnim, gameObject.transform.position, Quaternion.identity);
                gameObject.GetComponent<PolygonCollider2D>().enabled = false;
                gameObject.SetActive(false);
                audioSource.PlayOneShot(hitSound);
            }
            else
            {
                Destroy(collision.gameObject);
            }
          
            
        }
    }
}
