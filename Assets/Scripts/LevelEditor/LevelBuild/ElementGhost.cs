
using UnityEngine;

using UnityEngine.EventSystems;

public class ElementGhost : MonoBehaviour {

    public GameObject toolbarContent;
    public Transform idlePos;

    private void Update () {

        Vector3 targetPosition;
        float Xoverride = 0.0f;

        if (EventSystem.current.IsPointerOverGameObject()) {

            if (toolbarContent.activeSelf)
                targetPosition = Camera.main.ScreenToWorldPoint(idlePos.position);
            else {
                targetPosition = new Vector3(0.0f, 0.0f, 0.0f);
                Xoverride = -64.0f;
            }
        } else
            targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        targetPosition.z = Xoverride;

        transform.position = targetPosition;
    }
}
