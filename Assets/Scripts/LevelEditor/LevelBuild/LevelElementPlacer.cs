
using UnityEngine;

public class LevelElementPlacer : MonoBehaviour {

    private void Update () {

        if (Input.GetKeyDown(KeyCode.Mouse0)) {

            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            worldPosition.z = 0;

            PlaceElement(LevelEditorCache.currentSelectedType, worldPosition);
        }
    }

    private void PlaceElement (int type, Vector3 pos) {

        GameObject go = Instantiate(ElementTypes.instance.types[type], pos, Quaternion.identity);

        LevelEditorCache.currentLevel.elements.Add(new Element(type, go.transform));

        LevelEditorCache.objectCache.Add(go);
    }
}
