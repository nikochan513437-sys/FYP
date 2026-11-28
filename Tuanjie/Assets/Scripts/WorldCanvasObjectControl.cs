using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WorldCanvasObjectControl : MonoBehaviour
{
    public GameObject canvas1;
    public GameObject canvasObject;
    public void ControlWorldObj(string onoff,int canvasNum)
    {
        if (canvasNum == 1)
        {
            canvasObject = canvas1;
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
