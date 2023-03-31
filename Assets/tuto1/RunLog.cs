using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunLog : MonoBehaviour
{
    // 2 variables the string its gonna send and the color its gonna send
    [SerializeField]
    private string myText;
    [SerializeField]
    private Color myColor;
    [SerializeField]
    private TextLogControl logControl;

    public void LogText()
    {
        logControl.LogText(myText, myColor);// we're gonna send mytext and mycolor


    }

}