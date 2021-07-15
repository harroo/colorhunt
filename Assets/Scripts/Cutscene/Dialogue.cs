
using UnityEngine;

using UnityEngine.UI;

public class Dialogue : MonoBehaviour {

    public string textToDisplay;
    public float displaySpeed;

    private Text text;
    private float timer;
    private int index;

    private void Start () {

        text = GetComponent<Text>();
    }

    public void SkipDisplay () {

        index = textToDisplay.Length - 1;
        text.text = textToDisplay;
    }

    private void Update () {

        if (timer < 0) { timer = displaySpeed;

            if (text.text == textToDisplay) return;

            text.text += textToDisplay[index];
            index++;

        } else timer -= Time.deltaTime;
    }
}
