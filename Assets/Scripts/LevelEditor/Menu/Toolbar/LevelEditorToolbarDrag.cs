
using UnityEngine;

using UnityEngine.EventSystems;

public class LevelEditorToolbarDrag : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {

    public void OnPointerEnter (PointerEventData eventData) {

        mouseOver = true;
    }
    public void OnPointerExit (PointerEventData eventData) {

        mouseOver = false;
    }

    public Transform moveTarget;

    private bool mouseOver, dragging;

    private Vector3 posCache;

    private void Update () {

        if (mouseOver) {

            if (Input.GetMouseButtonDown(0)) {

                posCache = Input.mousePosition;
                dragging = true;
            }
        }

        if (Input.GetMouseButtonUp(0)) {

            dragging = false;
        }

        if (dragging) {

            moveTarget.position += (Input.mousePosition - posCache);
            posCache = Input.mousePosition;
        }
    }
}
