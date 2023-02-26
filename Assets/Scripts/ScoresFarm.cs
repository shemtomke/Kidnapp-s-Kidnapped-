using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoresFarm : MonoBehaviour
{
    public static int totalScore = 0;
    internal static object instance;


    public void OnGUI()
    {
        GUI.Box(new Rect(100, 20, 200, 30), totalScore.ToString());
    }



}
