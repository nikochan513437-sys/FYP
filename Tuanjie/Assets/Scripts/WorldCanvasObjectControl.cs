using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WorldCanvasObjectControl : MonoBehaviour
{
    public GameObject canvas1;
    public GameObject canvas2;
    public GameObject canvas3;
    public GameObject canvas4;
    public GameObject canvas5;
    GameObject canvasObject;
    public void ControlWorldObj(string onoff,int canvasNum)
    {
        if (canvasNum == 1)
        {
            canvasObject = canvas1;
        }
        if (canvasNum == 2)
        {
            canvasObject = canvas2;
        }
        if (canvasNum == 3)
        {
            canvasObject = canvas3;
        }
        if (canvasNum == 4)
        {
            canvasObject = canvas4;
        }
        if(canvasNum == 5)
        {
            canvasObject = canvas5;
        }
        if (onoff == "On")
        {
            canvasObject.SetActive(true);
        }
        else if(onoff =="Off")
        {
            canvasObject.SetActive(false);
        }
    }
}
