using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTutorialLoading : MonoBehaviour
{
    bool modeCorrect=false;
    bool stageFinish=false;
    bool doOnce = false;
    public int gameStage = 0;
    public ContourData contour;
    public Text hintText;
    public WorldCanvasObjectControl worldCanvasControl;
    public GameObject Player;
    void Start()
    {
        contour = FindAnyObjectByType<ContourData>();
        Debug.Log("aaa");
        //
        contour.setContourData("A1", "PMC18267R9", "HKG/C", "T/735");
        contour.updateData();
        stageFinish = true;
        //
        if (GameManager.GameMode== "Tutorial" && GameManager.GameLevel == "Loading")
        {
            modeCorrect = true;
            //contour = FindAnyObjectByType<ContourData>();
            //contour.setContourData("A1", "PMC18267R9", "HKG/C", "T/735");
        }
    }
    void Update()
    { 
        if (gameStage == 0 && modeCorrect) {
            stageFinish = true;
        }
        if (gameStage == 1 )
        {
            Stage1();
        }
        CheckStageFinish();
    }
    public void CheckStageFinish()
    {
        if (stageFinish)
        {
            stageFinish = false;
            gameStage++;
            doOnce = false;
        }
    }
    public void ChangeHintText(string txt)
    {
        hintText.text = txt;
    }
    public void Stage1()
    {
        if (!doOnce)
        {
            ChangeHintText("Walk over and check the PMC number of the contour");
            worldCanvasControl.ControlWorldObj("On", 1);
            doOnce = true;
        }
        
    }
}
