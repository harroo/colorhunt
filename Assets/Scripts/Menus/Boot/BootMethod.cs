
using System.IO;

using UnityEngine;

using UnityEngine.SceneManagement;

public class BootMethod : MonoBehaviour {

    private void Awake () {

        EnsureFolders();

        LoadMenu();
    }

    private void EnsureFolders () {

        if (!Directory.Exists(Application.persistentDataPath + "/Levels"))
            Directory.CreateDirectory(Application.persistentDataPath + "/Levels");

        if (!Directory.Exists(Application.persistentDataPath + "/Story"))
            Directory.CreateDirectory(Application.persistentDataPath + "/Story");
    }

    private void LoadMenu () {

        if (Application.platform == RuntimePlatform.Android) {

            SceneManager.LoadScene("MainMenu_Mobile_Boot");

        } else {

            SceneManager.LoadScene("MainMenu_PC_Boot");
        }
    }
}
