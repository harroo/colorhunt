
using System.IO;

using UnityEngine;
using UnityEngine.UI;

// using UnityEditor;

public class SaveLevel : MonoBehaviour {

    public void Save () {

        byte[] levelData = FindObjectOfType<LevelDeconstructor>().Deconstruct();

        PerformSave(levelData);
    }

    public InputField nameField;

    public void PerformSave (byte[] levelData) {

        string savePath = nameField.text;

        savePath = savePath.Replace('/', '_');
        savePath = savePath.Replace('\\', '_');
        savePath = savePath.Replace('\'', '_');
        savePath = savePath.Replace('\"', '_');
        savePath = savePath.Replace('~', '_');
        savePath = savePath.Replace('!', '_');
        savePath = savePath.Replace('@', '_');
        savePath = savePath.Replace('$', '_');
        savePath = savePath.Replace('%', '_');
        savePath = savePath.Replace('*', '_');
        savePath = savePath.Replace(';', '_');
        savePath = savePath.Replace(':', '_');

        savePath = Application.persistentDataPath + "/Levels/" + savePath + ".chm";

        // string savePath = EditorUtility.SaveFilePanel(
        //     "Save Level",
        //     Application.persistentDataPath + "/Levels",
        //     "My Awesome Level.chm",
        //     "chm"
        // );

        if (savePath.Length == 0) {

            PopupManager.Popup("Failed To Save!", "Filename was null.");

            // EditorUtility.DisplayDialog(
            //     "Something went wrong!",
            //     "You must enter a location to save the Level!",
            //     "Understood."
            // );

            return;
        }

        if (File.Exists(savePath)) {

            PopupManager.Popup("Failed To Save!", "Duplicate file found. Please try a different name.");
            return;
        }

        if (!Directory.Exists(Application.persistentDataPath + "/Levels"))
            Directory.CreateDirectory(Application.persistentDataPath + "/Levels");

        File.WriteAllBytes(savePath, levelData);

        nameField.text = "";
    }
}
