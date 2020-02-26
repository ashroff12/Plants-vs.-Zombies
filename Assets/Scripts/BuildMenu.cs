using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildMenu : MonoBehaviour
{
    public Texture sunImage;
    public BuildInfo[] plants;
    public static BuildInfo curPlant;
    void OnGUI(){
        GUILayout.BeginArea(new Rect(Screen.width/2 - 100, 30, 200, 100));
        GUILayout.BeginHorizontal("box");

        GUILayout.Box(new GUIContent(CollectSun.score.ToString(), sunImage));
        foreach(BuildInfo bi in plants){
            GUI.enabled = CollectSun.score >= bi.price;
            if(GUILayout.Button(new GUIContent(bi.price.ToString(), bi.previewImage))){
                curPlant = bi;
            }
        }

        GUILayout.EndHorizontal();
        GUILayout.EndArea();
}
}
