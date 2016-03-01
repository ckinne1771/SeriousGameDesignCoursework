using UnityEngine;
using System.Collections;

public class InteractScript : MonoBehaviour
{

    public Material IndustryMaterial;
    public GameObject coalSprite;
    public GameObject oilSprite;
    public GameObject solarSprite;
    public GameObject windSprite;
    private GameObject spwanPosition;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        if (Input.GetMouseButtonDown(0))
        {
            if (hit.collider.gameObject.tag == "emptyPanel")
            {
                hit.collider.gameObject.GetComponent<Renderer>().material = IndustryMaterial;
                string hitObject = hit.collider.gameObject.name;
                //  Instantiate(coalSprite, new Vector3( this.transform.position.x, this.transform.position.y, -7), this.transform.rotation);
              if(this.gameObject.name == hitObject)
                {
                    if (ButtonScript.coalSelected == true)
                    {
                        Instantiate(coalSprite, new Vector3(this.transform.position.x, this.transform.position.y, -7), this.transform.rotation);
                        ButtonScript.coalSelected = false;
                        ButtonScript.BuildingButtonsActive = false;
                        ButtonScript.cleanUpBool = true;
                    }
                    if (ButtonScript.oilSelected == true)
                    {
                        Instantiate(oilSprite, new Vector3(this.transform.position.x, this.transform.position.y, -7), this.transform.rotation);
                        ButtonScript.oilSelected = false;
                        ButtonScript.BuildingButtonsActive = false;
                        ButtonScript.cleanUpBool = true;
                    }
                    if (ButtonScript.solarSelected == true)
                    {
                        Instantiate(solarSprite, new Vector3(this.transform.position.x, this.transform.position.y, -7), this.transform.rotation);
                        ButtonScript.solarSelected = false;
                        ButtonScript.BuildingButtonsActive = false;
                        ButtonScript.cleanUpBool = true;
                    }
                    if (ButtonScript.windSelected == true)
                    {
                        Instantiate(windSprite, new Vector3(this.transform.position.x, this.transform.position.y, -7), this.transform.rotation);
                        ButtonScript.windSelected = false;
                        ButtonScript.BuildingButtonsActive = false;
                        ButtonScript.cleanUpBool = true;
                    }

                }

            }
         
        }
    }
}
