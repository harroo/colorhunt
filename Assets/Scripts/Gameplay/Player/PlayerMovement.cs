
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private Rigidbody2D rigidBody;

    private void Start () {

        rigidBody = GetComponent<Rigidbody2D>();
    }

    public float moveSpeed;
    public float jumpForce;
    public float gravity;

    private void Update () {

        leftPressed = Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow);

        rightPressed = Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow);

        jumpPressed = Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Space);
    }

    public bool leftPressed;
    public bool rightPressed;
    public bool jumpPressed;

    private void FixedUpdate () {

        if (leftPressed) rigidBody.AddForce(new Vector3(-moveSpeed, 0, 0));

        if (rightPressed) rigidBody.AddForce(new Vector3(moveSpeed, 0, 0));

        if (jumpPressed && onGround) rigidBody.AddForce(new Vector3(0, jumpForce, 0));

        if (!onGround) rigidBody.AddForce(new Vector3(0, -gravity, 0));
    }

    public bool onGround;

    private void OnCollisionEnter2D (Collision2D collision) {

        onGround = true;
    }

    private void OnCollisionStay2D (Collision2D collision) {

        onGround = true;
    }

    private void OnCollisionExit2D (Collision2D collision) {

        onGround = false;
    }
}
