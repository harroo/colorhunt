
using System.IO;

using UnityEngine;
using UnityEngine.UI;

using UnityEditor;

public class LoadLevel : MonoBehaviour {

    public void Load () {

        string loadPath = EditorUtility.OpenFilePanel(
            "Load Level",
            Application.persistentDataPath + "/Levels",
            "chm"
        );

        byte[] levelData = File.ReadAllBytes(loadPath);

        FindObjectOfType<LevelConstructor>().Construct(levelData);
    }
}
