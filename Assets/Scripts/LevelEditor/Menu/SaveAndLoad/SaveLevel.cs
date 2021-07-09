
using System.IO;

using UnityEngine;
using UnityEngine.UI;

using UnityEditor;

public class SaveLevel : MonoBehaviour {

    public void SaveAs () {

        byte[] levelData = FindObjectOfType<LevelDeconstructor>().Deconstruct();

        PerformSave(levelData);
    }

    public string saveCache = "";

    public void Save () {

        if (saveCache == "") SaveAs();
        else {

            byte[] levelData = FindObjectOfType<LevelDeconstructor>().Deconstruct();
            
            File.WriteAllBytes(saveCache, levelData);
        }
    }

    public void PerformSave (byte[] levelData) {

        string savePath = EditorUtility.SaveFilePanel(
            "Save Level",
            Application.persistentDataPath + "/Levels",
            "My Awesome Level.chm",
            "chm"
        );

        if (savePath.Length == 0) {

            EditorUtility.DisplayDialog(
                "Something went wrong!",
                "You must enter a location to save the Level!",
                "Understood."
            );

            return;
        }

        File.WriteAllBytes(savePath, levelData);

        saveCache = savePath;
    }
}
