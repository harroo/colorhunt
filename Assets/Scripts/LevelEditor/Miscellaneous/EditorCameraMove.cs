
using UnityEngine;

public class EditorCameraMove : MonoBehaviour {

    public float moveSpeed;

    private bool dragging;

    private Vector3 posCache;

    private void Update () {

        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow))
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);

        if (Input.GetMouseButtonDown(2)) {

            posCache = worldMousePos();
            dragging = true;
        }

        if (Input.GetMouseButtonUp(2)) {

            dragging = false;
        }

        if (dragging) {

            transform.position += (posCache - worldMousePos());
            posCache = worldMousePos();
        }
    }

    private Vector3 worldMousePos () {

        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
