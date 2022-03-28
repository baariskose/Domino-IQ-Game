using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    GameObject teleportCikis;
    // Start is called before the first frame update
    void Start()
    {
        teleportCikis = GameObject.FindGameObjectWithTag("isinlanmaCikis") as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Ball" || collision.gameObject.tag == "Stone")
        {
            collision.gameObject.transform.position = new Vector3(teleportCikis.transform.position.x, teleportCikis.transform.position.y, teleportCikis.transform.position.z);

        }
    }
}
