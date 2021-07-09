
using UnityEngine;

using UnityEngine.SceneManagement;

public class ColorDetector : MonoBehaviour {

    public string colorScene, colorlessScene, toggleableScene;

    private void Awake () {

        switch (PlayerPrefs.GetInt("ColorStage", 0)) {

            case 0: SceneManager.LoadScene(colorScene); break;

            case 1: SceneManager.LoadScene(colorlessScene); break;
            
            case 2: SceneManager.LoadScene(toggleableScene); break;
        }
    }
}
