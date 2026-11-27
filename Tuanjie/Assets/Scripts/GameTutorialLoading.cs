using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTutorialLoading : MonoBehaviour
{
    bool modeCorrect=false;
    public int gameStage=0;
    bool stageFinish=false;
    public ContourData contour;
    void Start()
    {
        contour = FindAnyObjectByType<ContourData>();
        Debug.Log("aaa");
        contour.setContourData("A1", "PMC18267R9", "HKG/C", "T/735");
        contour.updateData();
        if (GameManager.GameMode== "Tutorial" && GameManager.GameLevel == "Loading")
        {
            modeCorrect = true;
            //contour = FindAnyObjectByType<ContourData>();
            //contour.setContourData("A1", "PMC18267R9", "HKG/C", "T/735");
        }
    }
    void Update()
    {
        if (stageFinish)
        {
            gameStage++;
        }
        if (gameStage == 0 && modeCorrect) {
            gameStage=1;
        }

    }
}
