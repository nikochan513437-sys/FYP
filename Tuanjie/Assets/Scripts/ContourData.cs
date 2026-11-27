using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContourData : MonoBehaviour
{
    public bool isContourDataAllCorrect;
    //public double length;
    //public double height;
    //public double width;
    string contourType;
    /* sample of data
    data1 serialCode placeData batchCode
    A1 PMC18267R9 HKG/C T/735
    A2 PMC24247R9 HKG/C T/750
    */
    string data1;
    string serialCode;
    string placeData;
    string batchCode;
    public void setContourData(string data1,string data2,string data3,string data4)
    {
        isContourDataAllCorrect = true;
        contourType = "Q7";
        this.data1 = data1;
        serialCode = data2;
        placeData = data3;
        batchCode = data4;
    }
    public Text dataText;
    public Text PanelDataText;
    public void updateData()
    {
        string txt = data1 + " " + serialCode + "\n" + placeData + " " + batchCode;
        dataText.text = txt;
        if (isContourDataAllCorrect)
        {
            PanelDataText.text = txt;
        }
        else
        {
            PanelDataText.text = "A00 ABC10086D6"+"\n"+ "HKG/C T/735";
        }
    }
}
