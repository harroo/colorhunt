
using System.IO;

using UnityEngine;

// using UnityEditor;

public class OpenLevelFolderOnClick : MonoBehaviour {

    public void OnClick () {

        if (!Directory.Exists(Application.persistentDataPath + "/Levels"))
            Directory.CreateDirectory(Application.persistentDataPath + "/Levels");

        if (Directory.Exists(Application.persistentDataPath + "/Levels"))
            Application.OpenURL("file://" + Application.persistentDataPath + "/Levels");
        else
            Application.OpenURL("file://" + Application.persistentDataPath);
        // else
        //     EditorUtility.DisplayDialog(
        //         "Something went wrong!",
        //         "Unable to locate the Level-Folder, restarting the Application may help.",
        //         "Understood."
        //     );
    }
}

//
//
// EditorUtility.OpenFolderPanel("test", "", "");
// EditorUtility.DisplayDialog("Place Selection On Surface?",
//         "Are you sure you want to place " + transforms.Length
//         + " on the surface?", "Place", "Do Not Place"))
