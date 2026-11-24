using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //GameMode should be (Defalt)None,Normal or Tutorial
    public static string GameMode = "None";
    //GameProcess should be (Defalt)None,Loading,Unloading or Both
    public static string GameLevel = "None";
    public void chooseGameMode(string mode)
    {
        GameMode = mode;
        Debug.Log("Change mode in "+mode);
    }
    public void chooseGameLevel(string level)
    {
        GameLevel = level;
        Debug.Log("Choose game level in " + level);
    }
}
