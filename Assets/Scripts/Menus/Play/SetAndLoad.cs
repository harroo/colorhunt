
using UnityEngine;

using UnityEngine.SceneManagement;

public class SetAndLoad : MonoBehaviour {

    public string levelName;

    public void OnClick () {

        LevelLoadInfo.LevelPath = levelName;
        LevelLoadInfo.SceneForAfter = "LoadLevelToPlay";
        LevelLoadInfo.IsStory = false;

        SceneManager.LoadScene("LevelPlayer_Custom");
    }
}
