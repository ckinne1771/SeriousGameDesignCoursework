using UnityEngine;
using System.Collections;

public class ButtonScript : MonoBehaviour {

    public static bool BuildingButtonsActive = false;
    public static bool cleanUpBool = false;

    public static bool coalSelected = false;
    public static bool oilSelected = false;
    public static bool solarSelected = false;
    public static bool windSelected = false;
    public static bool nextturnSelected = false;
    public static int turnCount = 0;


    public GameObject BuildingButton1;
    public GameObject BuildingButton2;
    public GameObject BuildingButton3;
    public GameObject BuildingButton4;
    public GameObject NextTurnButton;
    // Use this for initialization

  
    private int lastPollutionBuildings;
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

    public void NextTurnToggle()
    {
        if (nextturnSelected == false)
        {
            nextturnSelected = true;
            NextTurn();
        }
        else if(nextturnSelected == true)
        {
            nextturnSelected = false;
        }
    }

    void NextTurn()
    {
        if(turnCount == 0)
        {
            lastPollutionBuildings = 0;
        }

        if(InteractScript.PollutionBuilding >= lastPollutionBuildings)
        {
            StatisticsScript.PollutionFactor += 10 * InteractScript.PollutionBuilding;
        }
        if(InteractScript.PollutionBuilding == lastPollutionBuildings )
        {
            if(InteractScript.PollutionBuilding==0)
            {

            }
            else
            {
                StatisticsScript.PollutionFactor += StatisticsScript.PollutionFactor;
            }
        }
        if(InteractScript.PollutionBuilding< lastPollutionBuildings)
        {
            StatisticsScript.PollutionFactor -= (10 * (lastPollutionBuildings - InteractScript.PollutionBuilding));
        }
        int currentPopulation;
        if (StatisticsScript.EnergyOutput >= StatisticsScript.EnergyDemand)
        {
            currentPopulation = StatisticsScript.Population;
            StatisticsScript.Population += (StatisticsScript.EnergyOutput - StatisticsScript.EnergyDemand) + 100 - StatisticsScript.PollutionFactor;
            StatisticsScript.Money += (StatisticsScript.EnergyOutput - StatisticsScript.EnergyDemand) + 300 + (StatisticsScript.Population - currentPopulation);
            StatisticsScript.EnergyDemand += StatisticsScript.Population - currentPopulation;
        }
        else{
            currentPopulation = StatisticsScript.Population;
            StatisticsScript.Population -= (StatisticsScript.EnergyDemand - StatisticsScript.EnergyOutput) - 100 - StatisticsScript.PollutionFactor;
            StatisticsScript.Money += (StatisticsScript.EnergyOutput - StatisticsScript.EnergyDemand) + 300 + (StatisticsScript.Population - currentPopulation);
            StatisticsScript.EnergyDemand += StatisticsScript.Population - currentPopulation;
        }

        nextturnSelected = false;
        turnCount++;
    }

}
