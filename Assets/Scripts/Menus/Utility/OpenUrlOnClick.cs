
using UnityEngine;

public class OpenUrlOnClick : MonoBehaviour {

    public string urlToOpen;

    public void OnClick () {

        Application.OpenURL(urlToOpen);
    }
}
