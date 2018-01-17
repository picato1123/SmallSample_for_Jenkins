using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class JBuilder : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    [UnityEditor.MenuItem("Tools/Build Project AllScene Android")]
    public static void BuildProjectAllSceneAndroid()
    {

        EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTargetGroup.Android, BuildTarget.Android);
        List<string> allScene = new List<string>();
        foreach (EditorBuildSettingsScene scene in EditorBuildSettings.scenes)
        {
            if (scene.enabled)
            {
                allScene.Add(scene.path);
            }
        }
        PlayerSettings.applicationIdentifier = "com.ht.sampleforjenkins";
        PlayerSettings.statusBarHidden = true;
        BuildPipeline.BuildPlayer(
            allScene.ToArray(),
            "BuildforJenkins.apk",
            BuildTarget.Android,
            BuildOptions.None
        );
    }
}
