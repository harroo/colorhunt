
using UnityEngine;

using UnityEngine.SceneManagement;

public class StartPos : MonoBehaviour {

    public GameObject display;

    private void Start () {

        if (SceneManager.GetActiveScene().name == "LevelEditor")
            return;

        Destroy(display);
    }
}
