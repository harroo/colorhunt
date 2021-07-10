
using UnityEngine;

public class ElementGhost : MonoBehaviour {

    private void Update () {

        Vector3 targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        targetPosition.z = 0;

        transform.position = targetPosition;
    }
}
