using UnityEditor;
using UnityEngine;
using System.Collections;
using System.IO;
using UnityEditor.Callbacks;
using System.Text.RegularExpressions;

public class Builder : MonoBehaviour
{
    public static void BuildOSX()
    {
		string[] scenes = {"Assets/DESKTOP_DEMOS/BasicObjectsDemo/ObjectsDemoScene.unity"};
        string error = BuildPipeline.BuildPlayer(scenes, "builds/Test.app", BuildTarget.StandaloneOSX, BuildOptions.None).ToString();
        if (error != "") Debug.Log("Build failed: " + error);
    }
    
    public static void BuildWindows()
    {
		string[] scenes = {"Assets/DESKTOP_DEMOS/BasicObjectsDemo/ObjectsDemoScene.unity"};
        string error = BuildPipeline.BuildPlayer(scenes, "builds/Test.exe", BuildTarget.StandaloneWindows64, BuildOptions.None).ToString();
        if (error != "") Debug.Log("Build failed: " + error);
    }
}
