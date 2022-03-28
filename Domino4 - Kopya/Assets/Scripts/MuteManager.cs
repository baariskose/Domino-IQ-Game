using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteManager : MonoBehaviour
{
    int toggleCounter;
    public bool isMuted;
    public Button musicButton;
    public Sprite[] sprites;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("Mute")==0)
        {
            AudioListener.pause = false;
            musicButton.image.sprite = sprites[0];
        }
        else
        {
            AudioListener.pause = true;
            musicButton.image.sprite = sprites[1];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void soundController()
    {
        toggleCounter++;
        if (toggleCounter % 2 == 0)
        {
            isMuted = false;
            AudioListener.pause = false;

            PlayerPrefs.SetInt("Mute", 0);
            musicButton.image.sprite = sprites[0];
        }
        else
        {
            musicButton.image.sprite = sprites[1];
            isMuted = true;
            PlayerPrefs.SetInt("Mute", 1);
            AudioListener.pause = true;

        }
    }
}
