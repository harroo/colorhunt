
using UnityEngine;
using UnityEngine.UI;

public class CutsceneController : MonoBehaviour {

    public Act[] acts;

    //loop through acts and play like that
}

[System.Serializable]
public class Act {

    public string dialogue;
    public GameObject background;
}
