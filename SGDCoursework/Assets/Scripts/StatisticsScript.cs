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

    //The Gaemobjects which represent the text output for the statistics
    public GameObject EnergyOutputText;
    public GameObject EnergyDemandText;
    public GameObject PopulationText;
    public GameObject MoneyText;
    public GameObject PollutionText;
    public GameObject TurnText;

	// At the start  of the game
	void Start () {
        EnergyDemand = 500;
        EnergyOutput = 0;
        Population = 1000;
        Money = 1500;
        PollutionFactor = 0;
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

