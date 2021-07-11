
using System.IO;

using UnityEngine;
using UnityEngine.UI;

// using UnityEditor;

public class LoadLevel : MonoBehaviour {

    public InputField nameField;

    public void Load () {

        string loadPath = nameField.text;

        loadPath = loadPath.Replace('/', '_');
        loadPath = loadPath.Replace('\\', '_');
        loadPath = loadPath.Replace('\'', '_');
        loadPath = loadPath.Replace('\"', '_');
        loadPath = loadPath.Replace('~', '_');
        loadPath = loadPath.Replace('!', '_');
        loadPath = loadPath.Replace('@', '_');
        loadPath = loadPath.Replace('$', '_');
        loadPath = loadPath.Replace('%', '_');
        loadPath = loadPath.Replace('*', '_');
        loadPath = loadPath.Replace(';', '_');
        loadPath = loadPath.Replace(':', '_');

        loadPath = Application.persistentDataPath + "/Levels/" + loadPath + ".chm";

        // string loadPath = EditorUtility.OpenFilePanel(
        //     "Load Level",
        //     Application.persistentDataPath + "/Levels",
        //     "chm"
        // );

        if (!File.Exists(loadPath)) {

            PopupManager.Popup("Failed To Load!", "No such map found.");
            return;
        }

        if (!Directory.Exists(Application.persistentDataPath + "/Levels"))
            Directory.CreateDirectory(Application.persistentDataPath + "/Levels");

        byte[] levelData = File.ReadAllBytes(loadPath);

        FindObjectOfType<LevelConstructor>().Construct(levelData);

        nameField.text = "";
    }
}
