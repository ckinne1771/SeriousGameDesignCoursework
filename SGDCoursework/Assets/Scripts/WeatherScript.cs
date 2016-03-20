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

    public static bool StormWeatherTodaySelected = false;
    public static bool RainWeatherTodaySelected = false;
    public static bool ClearWeatherTodaySelected = false;
    public static bool WindyWeatherTodaySelected = false;
    public static bool HeatwaveWeatherTodaySelected = false;

    public static bool StormWeatherTomorrowSelected = false;
    public static bool RainWeatherTomorrowSelected = false;
    public static bool ClearWeatherTomorrowSelected = false;
    public static bool WindyWeatherTomorrowSelected = false;
    public static bool HeatwaveWeatherTomorrowSelected = false;
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
    void ButtonPress()
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
    void Cleanup()
    {
        StormWeatherToday.SetActive(false);
        RainWeatherToday.SetActive(false);
        ClearWeatherToday.SetActive(false);
        WindyWeatherToday.SetActive(false);
        HeatwaveWeatherToday.SetActive(false);

        StormWeatherTodaySelected = false;
        RainWeatherTodaySelected = false;
        ClearWeatherTodaySelected = false;
        WindyWeatherTodaySelected = false;
        HeatwaveWeatherTodaySelected = false;

        StormWeatherTomorrow.SetActive(false);
        RainWeatherTomorrow.SetActive(false);
        ClearWeatherTomorrow.SetActive(false);
        WindyWeatherTomorrow.SetActive(false);
        HeatwaveWeatherTomorrow.SetActive(false);

        StormWeatherTomorrowSelected = false;
        RainWeatherTomorrowSelected = false;
        ClearWeatherTomorrowSelected = false;
        WindyWeatherTomorrowSelected = false;
        HeatwaveWeatherTomorrowSelected = false;
    }
	
	// Update is called once per frame
	void Update () {
	
        if (ButtonScript.weatherSelected == false)
        {
            ButtonPress();
        }
        
	}

    public void WeatherSelectionMethodStart()
    {
        if (ButtonScript.weatherSelected == true)
        {

            RandomWeatherNumber1 = Random.Range(0, 101);
            RandomWeatherNumber2 = Random.Range(0, 101);
            if (weatherAlreadySelected == false)
            {

                if (RandomWeatherNumber1 > 0 && RandomWeatherNumber1 < 11)
                {
                    StormWeatherToday.SetActive(true);
                    StormWeatherTodaySelected = true;
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
                    HeatwaveWeatherTodaySelected = true;
                }
                if (RandomWeatherNumber1 > 25 && RandomWeatherNumber1 < 61)
                {
                    StormWeatherToday.SetActive(false);
                    RainWeatherToday.SetActive(false);
                    ClearWeatherToday.SetActive(true);
                    ClearWeatherTodaySelected = true;
                    WindyWeatherToday.SetActive(false);
                    HeatwaveWeatherToday.SetActive(false);
                }
                if (RandomWeatherNumber1 > 60 && RandomWeatherNumber1 < 81)
                {
                    StormWeatherToday.SetActive(false);
                    RainWeatherToday.SetActive(true);
                    RainWeatherTodaySelected = true;
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
                    WindyWeatherTodaySelected = true;
                    HeatwaveWeatherToday.SetActive(false);
                }

                if (RandomWeatherNumber2 > 0 && RandomWeatherNumber2 < 11)
                {
                    StormWeatherTomorrow.SetActive(true);
                    StormWeatherTomorrowSelected = true;
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
                    HeatwaveWeatherTomorrowSelected = true;
                }
                if (RandomWeatherNumber2 > 25 && RandomWeatherNumber2 < 61)
                {
                    StormWeatherTomorrow.SetActive(false);
                    RainWeatherTomorrow.SetActive(false);
                    ClearWeatherTomorrow.SetActive(true);
                    ClearWeatherTomorrowSelected = true;
                    WindyWeatherTomorrow.SetActive(false);
                    HeatwaveWeatherTomorrow.SetActive(false);
                }
                if (RandomWeatherNumber2 > 60 && RandomWeatherNumber2 < 81)
                {
                    StormWeatherTomorrow.SetActive(false);
                    RainWeatherTomorrow.SetActive(true);
                    RainWeatherTomorrowSelected = true;
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
                    WindyWeatherTomorrowSelected = true;
                    HeatwaveWeatherTomorrow.SetActive(false);
                }
            }
            else
            {
                if (RainWeatherTodaySelected)
                {
                    RainWeatherToday.SetActive(true);
                }
                if(RainWeatherTomorrowSelected)
                {
                    RainWeatherTomorrow.SetActive(true);
                }
                if(HeatwaveWeatherTodaySelected)
                {
                    HeatwaveWeatherToday.SetActive(true);
                }
                if(HeatwaveWeatherTomorrowSelected)
                {
                    HeatwaveWeatherTomorrow.SetActive(true);
                }
                if(ClearWeatherTodaySelected)
                {
                    ClearWeatherToday.SetActive(true);
                }
                if(ClearWeatherTomorrowSelected)
                {
                    ClearWeatherTomorrow.SetActive(true);
                }
                if(StormWeatherTodaySelected)
                {
                    StormWeatherToday.SetActive(true);
                }
                if(StormWeatherTomorrowSelected)
                {
                    StormWeatherTomorrow.SetActive(true);
                }
                if(WindyWeatherTodaySelected)
                {
                    WindyWeatherToday.SetActive(true);
                }
                if(WindyWeatherTomorrowSelected)
                {
                    WindyWeatherTomorrow.SetActive(true);
                }
            }
        }


        else
        {
            ButtonPress();
        }

            weatherAlreadySelected = true;
        }


    public void NextWeather()
    {
        ButtonScript.weatherSelected = false;
        RandomWeatherNumber2 = Random.Range(0, 101);
        if(StormWeatherTomorrowSelected)
        {
            Cleanup();
            StormWeatherTodaySelected = true;
        }
        if (RainWeatherTomorrowSelected)
        {
            Cleanup();
            RainWeatherTodaySelected = true;
        }
        if (HeatwaveWeatherTomorrowSelected)
        {
            Cleanup();
            HeatwaveWeatherTodaySelected = true;
        }
        if (ClearWeatherTomorrowSelected)
        {
            Cleanup();
            ClearWeatherTodaySelected = true;
        }
        if (WindyWeatherTomorrowSelected)
        {
            Cleanup();
            WindyWeatherTodaySelected = true;
        }
        if (RandomWeatherNumber2 > 0 && RandomWeatherNumber2 < 11)
        {
         
            StormWeatherTomorrowSelected = true;
            
        }
        if (RandomWeatherNumber2 > 10 && RandomWeatherNumber2 < 26)
        {
            
            HeatwaveWeatherTomorrowSelected = true;
        }
        if (RandomWeatherNumber2 > 25 && RandomWeatherNumber2 < 61)
        {
            
            ClearWeatherTomorrowSelected = true;
          
        }
        if (RandomWeatherNumber2 > 60 && RandomWeatherNumber2 < 81)
        {
          
            RainWeatherTomorrowSelected = true;
           
        }
        if (RandomWeatherNumber2 > 80 && RandomWeatherNumber2 < 101)
        {
            
            WindyWeatherTomorrowSelected = true;
          
        }

    }

}


