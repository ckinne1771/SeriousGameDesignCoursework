using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StatisticsScript : MonoBehaviour {

    //Public variables which represent the staticstics which change during the gameplay
    public static int EnergyOutput;
    public static int Population;
    public static int EnergyDemand;
    public static int Money;
    public static int PollutionFactor;

    public int startingEnergyDemand;
    public int startingEnergyOutput;
    public int startingMoney;
    public int startingPopulation;
    public int startingPollution;

    public int CoalEnergyOutput;
    public int CoalCost;
    public int SolarEnergyOutput;
    public int SolarCost;
    public int OilEnergyOutput;
    public int OilCost;
    public int WindEnergyOutput;
    public int WindCost;

    public static int coalEnergyOutput;
    public static int coalCost;
    public static int solarEnergyOutput;
    public static int solarCost;
    public static int oilEnergyOutput;
    public static int oilCost;
    public static int windEnergyOutput;
    public static int windCost;

    //The Gaemobjects which represent the text output for the statistics
    public GameObject EnergyOutputText;
    public GameObject EnergyDemandText;
    public GameObject PopulationText;
    public GameObject MoneyText;
    public GameObject PollutionText;
    public GameObject TurnText;

	// At the start  of the game
	void Start () {
        EnergyDemand = startingEnergyDemand;
        EnergyOutput = startingEnergyOutput;
        Population = startingPopulation;
        Money = startingMoney;
        PollutionFactor = startingPollution;

        coalCost = CoalCost;
        coalEnergyOutput = CoalEnergyOutput;
        oilCost = OilCost;
        oilEnergyOutput = OilEnergyOutput;
        solarCost = SolarCost;
        solarEnergyOutput = SolarEnergyOutput;
        windCost = WindCost;
        windEnergyOutput = WindEnergyOutput;
	}
	
	// Update is called once per frame. Changes the value of the statistics on screen.
	void Update () {
        EnergyDemandText.GetComponent<Text>().text = "Energy Demand: " + EnergyDemand.ToString();
        EnergyOutputText.GetComponent<Text>().text = "Energy Output: " + EnergyOutput.ToString();
        PopulationText.GetComponent<Text>().text = "Population: " + Population.ToString();
        MoneyText.GetComponent<Text>().text = "Money: " + Money.ToString();
        PollutionText.GetComponent<Text>().text = "Pollution: " + PollutionFactor.ToString();
        TurnText.GetComponent<Text>().text = "Turn: " + ButtonScript.turnCount.ToString();
        
    }
}

