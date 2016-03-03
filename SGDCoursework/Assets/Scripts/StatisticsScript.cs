using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StatisticsScript : MonoBehaviour {

    //Public variables which represent the staticstics which change during the gameplay
    public static int EnergyOutput;
    public static int Population;
    public static int EnergyDemand;
    public static int Money;

    //The Gaemobjects which represent the text output for the statistics
    public GameObject EnergyOutputText;
    public GameObject EnergyDemandText;
    public GameObject PopulationText;
    public GameObject MoneyText;

	// At the start  of the game
	void Start () {
        EnergyDemand = 500;
        EnergyOutput = 0;
        Population = 1000;
        Money = 1500;
	}
	
	// Update is called once per frame. Changes the value of the statistics on screen.
	void Update () {
        EnergyDemandText.GetComponent<Text>().text = "Energy Demand: " + EnergyDemand.ToString();
        EnergyOutputText.GetComponent<Text>().text = "Energy Output: " + EnergyOutput.ToString();
        PopulationText.GetComponent<Text>().text = "Population: " + Population.ToString();
        MoneyText.GetComponent<Text>().text = "Money: " + Money.ToString();
        
    }
}

