using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSistemi : MonoBehaviour
{
    public Button[] buttons;
    public Button[] buttons2;
    public GameObject[] pages;
    int counter=0;
    // Start is called before the first frame update
    void Start()
    {
        pages[0].SetActive(true);
        pages[1].SetActive(false);
    }
    void Update()
    {
        kilitSistemi();
    }
    public void bolumAc(string bolum_ismi)
    {
       SceneManager.LoadScene(bolum_ismi);
    }
    public void kilitSistemi()
    {
        int bolums = PlayerPrefs.GetInt("bolum");
       
        if(pages[0].gameObject.activeInHierarchy)
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                if(bolums == 0)
                {
                    if(i!=0)
                    {
                        buttons[i].interactable = false;
                    }
                }
                else
                {
                    if (bolums + 1 >= int.Parse(buttons[i].name))
                    {
                        buttons[i].interactable = true;
                    }
                    else
                    {
                        buttons[i].interactable = false;
                    }
                }
            }
        }
        else if(pages[1].gameObject.activeInHierarchy)
        {
            for (int i = 0; i < buttons2.Length; i++)
            {
                if (bolums == 0)
                {
                    if (i != 0)
                    {
                        buttons2[i].interactable = false;
                    }
                }
                else
                {
                    if (bolums + 1 >= int.Parse(buttons2[i].name))
                    {
                        buttons2[i].interactable = true;
                    }
                    else
                    {
                        buttons2[i].interactable = false;
                    }
                }
            }
        }
    }
    public void nextPage()
    {
        counter++;
        if (counter %2 ==0)
        {
            pages[0].SetActive(true);
            pages[1].SetActive(false);
        }
        else
        {
            pages[0].SetActive(false);
            pages[1].SetActive(true);
        }
        kilitSistemi();
    }

}
