
using UnityEngine;

using UnityEngine.SceneManagement;

public class EditorPlayTest : MonoBehaviour {

    public void Play () {

        LevelEditorCache.playTesting = true;

        LevelLoadInfo.LevelPath = "/Temp/lvledt.chm";
        LevelLoadInfo.IsStory = false;

        SceneManager.LoadScene("LevelPlayer_Custom");
    }
}
