
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StoryModeMenu : MonoBehaviour {

    public string newGameScene, continueGameScene;

    public void OnNewGame () {

        if (PlayerPrefs.GetString("STORY_NEW", "TRUE") == "FALSE") {

            PopupManager.YesNoPopup("Start new game?", "Are you sure you want to reset the Story? Your progress will be lost.", ()=>{

                PlayerPrefs.SetInt("STORY_LEVEL", 0);
                PlayerPrefs.SetString("STORY_NEW", "TRUE");

                SceneManager.LoadScene(newGameScene);
            });

        } else {

            PlayerPrefs.SetInt("STORY_LEVEL", 0);
            PlayerPrefs.SetString("STORY_NEW", "TRUE");

            SceneManager.LoadScene(newGameScene);
        }
    }

    public void OnContinueGame () {

        if (PlayerPrefs.GetString("STORY_NEW", "TRUE") == "TRUE") {

            SceneManager.LoadScene(newGameScene);

        } else {

            SceneManager.LoadScene(continueGameScene);
        }
    }
}
