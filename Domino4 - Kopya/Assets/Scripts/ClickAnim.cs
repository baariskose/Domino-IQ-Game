using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickAnim : MonoBehaviour, IPointerClickHandler
{
    StoneCreator stoneCreator;
    TrailerController trailerController;
    // Start is called before the first frame update
    void Start()
    {
        stoneCreator = GameObject.Find("Script").GetComponent<StoneCreator>();
        trailerController = GameObject.Find("Script").GetComponent<TrailerController>();
    }

    // Update is called once per frame
    void Update()
    {
     

    }
   

    public void OnPointerClick(PointerEventData eventData)
    {
        stoneCreator.CreateStone();
        trailerController.isClickFirstLevelButton = true;
    }
}
