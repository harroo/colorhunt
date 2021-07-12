
using UnityEngine;

public class ElementSelector : MonoBehaviour {

    public Transform elementGhost;

    public void SetElement (int type) {

        LevelEditorCache.currentSelectedType = type;

        foreach (Transform child in elementGhost) {

            Destroy(child.gameObject);
        }

        GameObject go = Instantiate(
            ElementTypes.instance.types[type],
            elementGhost.position,
            elementGhost.rotation
        );
        go.transform.SetParent(elementGhost);
        go.transform.localScale = new Vector3(
            LevelEditorCache.scaleX,
            LevelEditorCache.scaleY,
            1.0f
        );

        if (type == 1) {

            Destroy(go.GetComponent<StartPos>());

        }
    }

    public void SetScaleX (float val) {

        LevelEditorCache.scaleX = val;

        foreach (Transform child in elementGhost) {

            child.localScale = new Vector3(
                val,
                child.localScale.y,
                child.localScale.z
            );
        }
    }

    public void SetScaleY (float val) {

        LevelEditorCache.scaleY = val;

        foreach (Transform child in elementGhost) {

            child.localScale = new Vector3(
                child.localScale.x,
                val,
                child.localScale.z
            );
        }
    }

    private void Start () {

        SetElement(0);
        SetScaleX(8);
        SetScaleY(8);
    }
}
