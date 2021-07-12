
using System.IO;

using UnityEngine;

public class EditorLoadCheck : MonoBehaviour {

    private void Start () {

        if (LevelEditorCache.playTesting) {

            LevelEditorCache.playTesting = false;

            byte[] levelData = File.ReadAllBytes(Application.persistentDataPath + "/Temp/lvledt.chm");

            FindObjectOfType<LevelConstructor>().Construct(levelData);
        }
    }
}
