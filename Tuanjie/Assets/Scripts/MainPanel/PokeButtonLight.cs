using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokeButtonLight : MonoBehaviour
{
    private Material defMat;
    public Material lightMat;
    private MeshRenderer render;
    private bool isTurnOn;

    private void Awake()
    {
        render = GetComponent<MeshRenderer>();
        defMat = GetComponent<MeshRenderer>().materials[0];
    }

    public void onPokePress() {
        //Debug.Log("Button Pressed");
        if (!isTurnOn)
        {
            render.material = lightMat;
            isTurnOn = true;
        }
        else { 
            render.material = defMat;
            isTurnOn=false;
        }
    }
}
