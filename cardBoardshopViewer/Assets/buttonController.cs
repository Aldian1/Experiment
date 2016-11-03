using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class buttonController : MonoBehaviour {
    public Color[] colors;

    public List<Material> Materials = new List<Material>();

    private int currentMaterialindex;

    private Renderer rend;

    private Text styleText;

    public GameObject[] ModelParts;
    void Start()
    {
        rend = GetComponent<Renderer>();
        styleText = GameObject.FindGameObjectWithTag("Style").GetComponent<Text>();
    }
    

    public void gazeHovertrue(Image button)
    {
        button.CrossFadeColor(colors[1], .3F,false,false);
    }

    public void gazeHoverfalse(Image button)
    {
        button.CrossFadeColor(colors[0], .3F, false, false);
    }

    public void gazeClicked()
    {
        changeColor();
    }

    protected void changeColor()
    {


        if (currentMaterialindex == Materials.Count - 1)
        {
            currentMaterialindex = 0;
            
        }
        else if (currentMaterialindex < Materials.Count - 1)
        { currentMaterialindex += 1; }

        foreach (GameObject parts in ModelParts)
        {
            parts.GetComponent<Renderer>().material = Materials[currentMaterialindex];
            
        }

        //update text
        styleText.text = "Style: " + Materials[currentMaterialindex].name;


    }
}
