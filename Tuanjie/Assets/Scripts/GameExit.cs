using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public void GameExit()
    {
        Debug.Log("Exited");
        Application.Quit();
    }
}
