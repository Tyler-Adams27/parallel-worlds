using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int buttonsPressed;
    public int buttonsToBePressed;
    public bool isInSecondWorld = false;
    public GameObject walls;
    public GameObject floor;
    public Material purple;
    void Start()
    {

    }


    void Update()
    {
        SwitchWorld();
    }


    void SwitchWorld()
    {
        if (Input.GetKeyDown(KeyCode.Tab) && !isInSecondWorld)
        {
            walls.transform.GetComponent<Renderer>().material = purple;
            floor.transform.GetComponent<Renderer>().material = purple;


        }
        else
        {
            isInSecondWorld = false;
        }
    }

    
}
