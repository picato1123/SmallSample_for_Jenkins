using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class JBuilder : MonoBehaviour
{
    public static void Build()
    {
        //ビルド対象シーンリスト
        string[] sceneList =
        {
            "./Assets/Main.unity"
        };

        //実行
        string errorMessage = BuildPipeline.BuildPlayer
            (
            sceneList,
            "C:/Users/hisat/Unity_project/SmallSample_for_Jenkins/SSampleJK.apk",
            BuildTarget.Android,
            BuildOptions.Development
            );

        //出力結果
        if (!string.IsNullOrEmpty(errorMessage))
            Debug.LogError("[Error!]" + errorMessage);
        else
            Debug.Log("[Sucess!]");
    }

}
