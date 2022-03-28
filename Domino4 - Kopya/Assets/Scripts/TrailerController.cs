using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TrailerController : MonoBehaviour
{
   
    public List<Image> animatons;
    public List<GameObject> animations2;
    public Button closeButton;
    public Text timeHelpText;
    bool isClickClose;
    public bool isClickFirstLevelButton;
    // Start is called before the first frame update
    void Start()
    {
        isClickClose = false;
        isClickFirstLevelButton = false;
        Invoke("teleportAnimControl", 1);
    }

    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene().buildIndex == 2 && isClickFirstLevelButton)
        {
            timeHelpText.enabled = true;
            foreach (var anim in animatons)
            {
                anim.enabled = true;
            }
            foreach (var anim in animations2)
            {
                anim.SetActive(true);
            }
        }
    }
    public void closeAnim()
    {
        foreach (var anim in animatons)
        {
                anim.enabled = false;
                isClickClose = false;
                closeButton.image.enabled = false;
        }
    }
    public void teleportAnimControl()
    {
        if (SceneManager.GetActiveScene().buildIndex == 42)
        {
            animatons[animatons.Count - 1].enabled = true;
            animatons[3].enabled = false;
        }
    }
}
