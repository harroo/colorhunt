
using System.IO;

using UnityEngine;

using UnityEngine.UI;

public class PlayMenu : MonoBehaviour {

    private void Start () {

        if (!Directory.Exists(Application.persistentDataPath + "/Levels"))
            Directory.CreateDirectory(Application.persistentDataPath + "/Levels");

        LoadView();
    }

    public void Refresh () {

        LoadView();
    }

    public GameObject slotPrefab;
    public Transform parent;

    private void LoadView () {

        slotPrefab.SetActive(false);

        foreach (Transform child in parent) {

            if (child.gameObject.activeSelf)
                Destroy(child.gameObject);
        }

        slotPrefab.SetActive(true);

        foreach (string file in Directory.GetFiles(Application.persistentDataPath + "/Levels", "*.chm")) {

            file.Replace('\\', '/');
            string[] values = file.Split('/');
            string name = values[values.Length - 1];

            CreateSlot(name);
        }

        slotPrefab.SetActive(false);
    }
    private void CreateSlot (string name) {

        GameObject slot = Instantiate(
            slotPrefab,
            slotPrefab.transform.position,
            slotPrefab.transform.rotation
        );

        slot.name = "Slot: " + name;

        slot.transform.SetParent(parent);
        slot.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);

        slot.GetComponent<SetAndLoad>().levelName = "/Levels/" + name;
        slot.GetComponentInChildren<Text>().text = name;
    }
}
