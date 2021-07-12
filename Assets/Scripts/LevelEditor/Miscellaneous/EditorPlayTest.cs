
using System.IO;

using UnityEngine;

using UnityEngine.SceneManagement;

public class EditorPlayTest : MonoBehaviour {

    public void Play () {

        if (!Directory.Exists(Application.persistentDataPath + "/Temp"))
            Directory.CreateDirectory(Application.persistentDataPath + "/Temp");

        byte[] levelData = FindObjectOfType<LevelDeconstructor>().Deconstruct();
        File.WriteAllBytes(Application.persistentDataPath + "/Temp/lvledt.chm", levelData);

        LevelEditorCache.playTesting = true;

        LevelLoadInfo.LevelPath = "/Temp/lvledt.chm";
        LevelLoadInfo.SceneForAfter = "LevelEditor";
        LevelLoadInfo.IsStory = false;

        SceneManager.LoadScene("LevelPlayer_Custom");
    }
}
