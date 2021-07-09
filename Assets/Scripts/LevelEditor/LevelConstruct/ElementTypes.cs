
using UnityEngine;

public class ElementTypes : MonoBehaviour {

    public static ElementTypes instance;

    private void Awake () {

        instance = this;
    }

    public GameObject[] types;
}
