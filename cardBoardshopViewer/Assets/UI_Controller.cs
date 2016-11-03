using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class UI_Controller : MonoBehaviour {

    public GameObject[] mainUI;
    void Start()
    {
        mainUI = GameObject.FindGameObjectsWithTag("mainUI");

        setUIalpha();   
    }
    public void initMainui()
    {
        Debug.Log("Event");
        foreach(GameObject uiElement in mainUI)
        {
            uiElement.GetComponent<Image>().CrossFadeAlpha(255F, 5, false);
        }
    }

    protected void setUIalpha()
    {
        foreach (GameObject uiElement in mainUI)
        {
            if(uiElement.GetComponent<Image>())
            { uiElement.GetComponent<Image>().CrossFadeAlpha(1, 1, false); }
            if(uiElement.GetComponent<Text>())
            { uiElement.GetComponent<Text>().CrossFadeAlpha(1, 1, false); }

        }
    }
}
