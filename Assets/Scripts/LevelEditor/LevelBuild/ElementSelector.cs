
using UnityEngine;

public class ElementSelector : MonoBehaviour {

    public Transform elementGhost;

    public void SetElement (int type) {

        LevelEditorCache.currentSelectedType = type;

        foreach (Transform child in elementGhost) {

            Destroy(child.gameObject);
        }

        Instantiate(
            ElementTypes.instance.types[type],
            elementGhost.position,
            elementGhost.rotation
        ).transform.SetParent(elementGhost);
    }

    //TEMP
    public int x;int y;private void Update(){if(x!=y){y=x;SetElement(x);}}
}
