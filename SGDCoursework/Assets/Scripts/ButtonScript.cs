using UnityEngine;
using System.Collections;

public class ButtonScript : MonoBehaviour {

    public static bool BuildingButtonsActive = false;
    public static bool cleanUpBool = false;

    public static bool coalSelected = false;
    public static bool oilSelected = false;
    public static bool solarSelected = false;
    public static bool windSelected = false;



    public GameObject BuildingButton1;
    public GameObject BuildingButton2;
    public GameObject BuildingButton3;
    public GameObject BuildingButton4;
    // Use this for initialization

    void Update()
    {
        if (cleanUpBool == true)
        {
            BuildingButtonsActive = false;
            BuildingButton1.SetActive(false);
            BuildingButton2.SetActive(false);
            BuildingButton3.SetActive(false);
            BuildingButton4.SetActive(false);
            cleanUpBool = false;
        }
        
    }



    public void BuildingButtonsToggle()
    {
        if (BuildingButtonsActive == false)
        {
            BuildingButtonsActive = true;
            BuildingButton1.SetActive(true);
            BuildingButton2.SetActive(true);
            BuildingButton3.SetActive(true);
            BuildingButton4.SetActive(true);
        }
        else if(BuildingButtonsActive == true)
        {
            BuildingButtonsActive = false;
            BuildingButton1.SetActive(false);
            BuildingButton2.SetActive(false);
            BuildingButton3.SetActive(false);
            BuildingButton4.SetActive(false);
        }
    }

    public void coalToggle()
    {
        if(coalSelected ==false)
        {
            coalSelected = true;
        }
        else if (coalSelected == true)
        {
            coalSelected = false;
        }

    }

    public void oilToggle()
    {
        if (oilSelected == false)
        {
            oilSelected = true;
        }
        else if (oilSelected == true)
        {
            oilSelected = false;
        }

    }
    public void solarToggle()
    {
        if (solarSelected == false)
        {
            solarSelected = true;
        }
        else if (solarSelected == true)
        {
            solarSelected = false;
        }

    }
    public void windToggle()
    {
        if (windSelected == false)
        {
            windSelected = true;
        }
        else if (coalSelected == true)
        {
            windSelected = false;
        }

    }

}
