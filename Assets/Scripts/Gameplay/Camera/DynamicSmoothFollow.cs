
using UnityEngine;

public class DynamicSmoothFollow : MonoBehaviour {

    public float lerpSpeed;

    public Transform target;

    public float dynamicOffsetX, offsetY, offsetZ;
    private float offsetX;

    private PlayerMovement movement;

    private void Start () {

        movement = FindObjectOfType<PlayerMovement>();
    }

    private void Update () {

        if (movement.leftPressed)
            offsetX = -dynamicOffsetX;
        else if (movement.rightPressed)
            offsetX = dynamicOffsetX;
    }

    private void LateUpdate () {

        Vector3 offset = new Vector3(offsetX, offsetY, offsetZ);

        Vector3 currentPosition = transform.position;
        Vector3 targetPosition = target.position + offset;

        float speed = lerpSpeed * Time.deltaTime;

        transform.position = Vector3.Lerp(currentPosition, targetPosition, speed);
    }
}
