using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class buttonController : MonoBehaviour {
    public Color[] colors;

    public Material[] Materials;

    private Renderer rend;
    void Start()
    {
        rend = GetComponent<Renderer>();
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

    }
}
