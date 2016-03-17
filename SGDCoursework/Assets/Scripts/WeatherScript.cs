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

    private bool weatherAlreadySelected = false;
    // Use this for initialization
    void Start () {
        StormWeatherToday.SetActive(false);
        RainWeatherToday.SetActive(false);
        ClearWeatherToday.SetActive(false);
        WindyWeatherToday.SetActive(false);
        HeatwaveWeatherToday.SetActive(false);

        StormWeatherTomorrow.SetActive(false);
        RainWeatherTomorrow.SetActive(false);
        ClearWeatherTomorrow.SetActive(false);
        WindyWeatherTomorrow.SetActive(false);
        HeatwaveWeatherTomorrow.SetActive(false);
	}
    void Cleanup()
    {
        StormWeatherToday.SetActive(false);
        RainWeatherToday.SetActive(false);
        ClearWeatherToday.SetActive(false);
        WindyWeatherToday.SetActive(false);
        HeatwaveWeatherToday.SetActive(false);

        StormWeatherTomorrow.SetActive(false);
        RainWeatherTomorrow.SetActive(false);
        ClearWeatherTomorrow.SetActive(false);
        WindyWeatherTomorrow.SetActive(false);
        HeatwaveWeatherTomorrow.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
	
        
        
	}

    public void WeatherSelectionMethodStart()
    {
        if (ButtonScript.weatherSelected == true)
        {

            RandomWeatherNumber1 = Random.Range(0, 101);
            RandomWeatherNumber2 = Random.Range(0, 101);

            if (RandomWeatherNumber1 > 0 && RandomWeatherNumber1 < 11)
            {
                StormWeatherToday.SetActive(true);
                RainWeatherToday.SetActive(false);
                ClearWeatherToday.SetActive(false);
                WindyWeatherToday.SetActive(false);
                HeatwaveWeatherToday.SetActive(false);
            }
            if (RandomWeatherNumber1 > 10 && RandomWeatherNumber1 < 26)
            {
                StormWeatherToday.SetActive(false);
                RainWeatherToday.SetActive(false);
                ClearWeatherToday.SetActive(false);
                WindyWeatherToday.SetActive(false);
                HeatwaveWeatherToday.SetActive(true);
            }
            if (RandomWeatherNumber1 > 25 && RandomWeatherNumber1 < 61)
            {
                StormWeatherToday.SetActive(false);
                RainWeatherToday.SetActive(false);
                ClearWeatherToday.SetActive(true);
                WindyWeatherToday.SetActive(false);
                HeatwaveWeatherToday.SetActive(false);
            }
            if (RandomWeatherNumber1 > 60 && RandomWeatherNumber1 < 81)
            {
                StormWeatherToday.SetActive(false);
                RainWeatherToday.SetActive(true);
                ClearWeatherToday.SetActive(false);
                WindyWeatherToday.SetActive(false);
                HeatwaveWeatherToday.SetActive(false);
            }
            if (RandomWeatherNumber1 > 80 && RandomWeatherNumber1 < 101)
            {
                StormWeatherToday.SetActive(false);
                RainWeatherToday.SetActive(false);
                ClearWeatherToday.SetActive(false);
                WindyWeatherToday.SetActive(true);
                HeatwaveWeatherToday.SetActive(false);
            }

            if (RandomWeatherNumber2 > 0 && RandomWeatherNumber2 < 11)
            {
                StormWeatherTomorrow.SetActive(true);
                RainWeatherTomorrow.SetActive(false);
                ClearWeatherTomorrow.SetActive(false);
                WindyWeatherTomorrow.SetActive(false);
                HeatwaveWeatherTomorrow.SetActive(false);
            }
            if (RandomWeatherNumber2 > 10 && RandomWeatherNumber2 < 26)
            {
                StormWeatherTomorrow.SetActive(false);
                RainWeatherTomorrow.SetActive(false);
                ClearWeatherTomorrow.SetActive(false);
                WindyWeatherTomorrow.SetActive(false);
                HeatwaveWeatherTomorrow.SetActive(true);
            }
            if (RandomWeatherNumber2 > 25 && RandomWeatherNumber2 < 61)
            {
                StormWeatherTomorrow.SetActive(false);
                RainWeatherTomorrow.SetActive(false);
                ClearWeatherTomorrow.SetActive(true);
                WindyWeatherTomorrow.SetActive(false);
                HeatwaveWeatherTomorrow.SetActive(false);
            }
            if (RandomWeatherNumber2 > 60 && RandomWeatherNumber2 < 81)
            {
                StormWeatherTomorrow.SetActive(false);
                RainWeatherTomorrow.SetActive(true);
                ClearWeatherTomorrow.SetActive(false);
                WindyWeatherTomorrow.SetActive(false);
                HeatwaveWeatherTomorrow.SetActive(false);
            }
            if (RandomWeatherNumber2 > 80 && RandomWeatherNumber2 < 101)
            {
                StormWeatherTomorrow.SetActive(false);
                RainWeatherTomorrow.SetActive(false);
                ClearWeatherTomorrow.SetActive(false);
                WindyWeatherTomorrow.SetActive(true);
                HeatwaveWeatherTomorrow.SetActive(false);
            }
        }
        else
        {
            Cleanup();
        }
    }
}
