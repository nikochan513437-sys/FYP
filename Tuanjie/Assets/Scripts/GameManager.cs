using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //GameMode should be None,Normal or Tutorial
    public static string GameMode = "None";
    //GameProcess should be None,Loading or Unloading
    public static string GameProcess = "None";
    public void chooseGameMode(string mode)
    {
        GameMode = mode;
        Debug.Log("Change mode in "+mode);
    }
    public void chooseGameProcess(string process)
    {
        GameProcess = process;
        Debug.Log("Change game process in " + process);
    }
}
