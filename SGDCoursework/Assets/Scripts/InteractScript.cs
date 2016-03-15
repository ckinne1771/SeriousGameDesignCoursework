using UnityEngine;
using System.Collections;

public class InteractScript : MonoBehaviour
{

    // Public variables for the interaction script. These hold a material which is used for changing the material of the background square on build
    //and for holding sprites which represent the different buildings the player can build.
    public Material IndustryMaterial;
    public GameObject coalSprite;
    public GameObject oilSprite;
    public GameObject solarSprite;
    public GameObject windSprite;
    private GameObject spwanPosition;
    public static int PollutionBuilding = 0;

   

    // Update is called once per frame
    void Update()
    {
        //We are using raycasting for the interactions with the square. We only try to detect hits once we click the left mouse button
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        if (Input.GetMouseButtonDown(0))
        {
            //if the ray hits an empty panel TODO set panle with building on it to "filledPanel"
            if (hit.collider.gameObject.tag == "emptyPanel")
            {
                //changes the material of the square
                hit.collider.gameObject.GetComponent<Renderer>().material = IndustryMaterial;
                //get the name of the hit square. We use the name of the object for detecting which panel was clicked. Without it, a building will be built on all squares (Yep, it was a bit funky).
                string hitObject = hit.collider.gameObject.name;


                if (this.gameObject.name == hitObject)
                {
                    //if we are building a coal power plant
                    if (ButtonScript.coalSelected == true)
                    {
                        Instantiate(coalSprite, new Vector3(this.transform.position.x, this.transform.position.y, -7), this.transform.rotation);
                        StatisticsScript.EnergyOutput += StatisticsScript.coalEnergyOutput;
                        StatisticsScript.Money -= StatisticsScript.coalCost;
                        PollutionBuilding++;
                        //    StatisticsScript.PollutionFactor += 10;
                        ButtonScript.coalSelected = false;
                        ButtonScript.BuildingButtonsActive = false;
                        ButtonScript.cleanUpBool = true;
                    }
                    // if we are building an oil refinery
                    if (ButtonScript.oilSelected == true)
                    {
                        Instantiate(oilSprite, new Vector3(this.transform.position.x, this.transform.position.y, -7), this.transform.rotation);
                        StatisticsScript.EnergyOutput += StatisticsScript.oilEnergyOutput;
                        StatisticsScript.Money -= StatisticsScript.oilCost;
                        PollutionBuilding++;
                        // StatisticsScript.PollutionFactor += 10;
                        ButtonScript.oilSelected = false;
                        ButtonScript.BuildingButtonsActive = false;
                        ButtonScript.cleanUpBool = true;
                    }
                    //if we are building a solar power plant
                    if (ButtonScript.solarSelected == true)
                    {
                        Instantiate(solarSprite, new Vector3(this.transform.position.x, this.transform.position.y, -7), this.transform.rotation);
                        StatisticsScript.EnergyOutput += StatisticsScript.solarEnergyOutput;
                        StatisticsScript.Money -= StatisticsScript.solarCost;
                        ButtonScript.solarSelected = false;
                        ButtonScript.BuildingButtonsActive = false;
                        ButtonScript.cleanUpBool = true;
                    }
                    //if we are building a wind farm
                    if (ButtonScript.windSelected == true)
                    {
                        Instantiate(windSprite, new Vector3(this.transform.position.x, this.transform.position.y, -7), this.transform.rotation);
                        StatisticsScript.EnergyOutput += StatisticsScript.windEnergyOutput;
                        StatisticsScript.Money -= StatisticsScript.windCost;
                        ButtonScript.windSelected = false;
                        ButtonScript.BuildingButtonsActive = false;
                        ButtonScript.cleanUpBool = true;
                    }

                }

            }
            else if (hit.collider.gameObject.tag == "PollutedBuilding")
            {
                Debug.Log("hitting");

                if (ButtonScript.demolishSelected == true)
                {
                    StatisticsScript.Money -= 5;
                    PollutionBuilding--;
                    Destroy(hit.collider.gameObject);
                }
            }
            else if (hit.collider.gameObject.tag == "GreenBuilding")
            {
                if (ButtonScript.demolishSelected == true)
                {
                    StatisticsScript.Money -= 5;
                    Destroy(hit.collider.gameObject);
                }
            }
         
        }
    }
}
