using UnityEngine;
using System.Collections;

public class InteractScript : MonoBehaviour
{

    public Material IndustryMaterial;
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
            }
         
        }
    }
}
