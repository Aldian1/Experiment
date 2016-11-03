using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Control_System : MonoBehaviour {

    public GameObject[] fadeInitems;
    public GameObject Model;

    public float smoothTime = 0.3F;
    private float yVelocity = 0.0F;

    public Color Gazeon;
    public Color Gazeoff;

    public bool spin;

    public enum SpinType { Spinright = 1, SpinLeft = 2};
    public SpinType type;

    void Start()
    {
        //get model from list or something
    }
    void Update()
    {
        if (spin == true)
        {
            if (type == SpinType.SpinLeft)
            {
                
                Model.transform.Rotate(0, -20 * Time.deltaTime, 0);
            }
            if (type == SpinType.Spinright)
            {
                Model.transform.Rotate(0, 20 * Time.deltaTime, 0);
               
            }
        }
    }
    public void openControlsystem()
    {
        foreach(GameObject Item in fadeInitems)
        {
            Item.GetComponent<Image>().CrossFadeAlpha(255, .5F, false);
        }
        this.GetComponent<Image>().CrossFadeAlpha(0, .5F, false);
        //this.gameObject.SetActive(false);
        
        //Move shoes up
        MoveShoes();
    }
    protected void MoveShoes()
    {
       
       
    }

    public void SpinRight()
    {

        type = SpinType.Spinright;
     
    }
    public void SpinLeft()
    {
        type = SpinType.SpinLeft;

    }

    public void GazeOn(Image image)
    {
        image.CrossFadeColor(Gazeon, .4F, false, false);
        spin = true;
    }

    public void GazeOff(Image image)
    {
        image.CrossFadeColor(Gazeoff, .4F, false, false);
        spin = false;
    }
    
}
