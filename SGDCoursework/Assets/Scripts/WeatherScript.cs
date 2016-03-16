using UnityEngine;
using System.Collections;

public class WeatherScript : MonoBehaviour {

    public GameObject StormWeatherToday;
    public GameObject RainWeatherToday;
    public GameObject ClearWeatherToday;
    public GameObject WindyWeatherToday;
    public GameObject HeatwaveWeatherToday;

    public GameObject StormWeatherTomorrow;
    public GameObject RainWeatherTomorrow;
    public GameObject ClearWeatherTomorrow;
    public GameObject WindyWeatherTomorrow;
    public GameObject HeatwaveWeatherTomorrow;


    private int RandomWeatherNumber1;
    private int RandomWeatherNumber2;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void WeatherSelectionMethod()
    {
        RandomWeatherNumber1 = Random.Range(0, 101);
        RandomWeatherNumber2 = Random.Range(0, 101);

        if (RandomWeatherNumber1 > 0 && RandomWeatherNumber1 < 11)
        {

        }
        if (RandomWeatherNumber1 > 10 && RandomWeatherNumber1 < 26)
        {

        }
        if (RandomWeatherNumber1 > 25 && RandomWeatherNumber1 < 61)
        {

        }
        if (RandomWeatherNumber1 > 60 && RandomWeatherNumber1 < 81)
        {

        }
        if (RandomWeatherNumber1 > 80 && RandomWeatherNumber1 < 101)
        {

        }

        if (RandomWeatherNumber2 > 0 && RandomWeatherNumber2 < 11)
        {

        }
        if (RandomWeatherNumber2 > 10 && RandomWeatherNumber2 < 26)
        {

        }
        if (RandomWeatherNumber2 > 25 && RandomWeatherNumber2 < 61)
        {

        }
        if (RandomWeatherNumber2 > 60 && RandomWeatherNumber2 < 81)
        {

        }
        if (RandomWeatherNumber2 > 80 && RandomWeatherNumber2 < 101)
        {

        }
    }
}
