
using UnityEngine;

using UnityEngine.EventSystems;

public class LevelElementPlacer : MonoBehaviour {

    private void Update () {

        if (Input.GetKeyDown(KeyCode.Mouse0)) {

            if (EventSystem.current.IsPointerOverGameObject()) return;

            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            worldPosition.z = 0;

            PlaceElement(LevelEditorCache.currentSelectedType, worldPosition);
        }
    }

    private void PlaceElement (int type, Vector3 pos) {

        if (type == 1) { if (FindObjectOfType<StartPos>() != null) {

            Destroy(FindObjectOfType<StartPos>().gameObject);
        }}

        GameObject go = Instantiate(ElementTypes.instance.types[type], pos, Quaternion.identity);
        go.transform.localScale = new Vector3(LevelEditorCache.scaleX, LevelEditorCache.scaleY, 1.0f);

        LevelEditorCache.currentLevel.elements.Add(new Element(type, go.transform));
        LevelEditorCache.objectCache.Add(go);
    }
}
