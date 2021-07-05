
using UnityEngine;

public class PlayerAnimation : MonoBehaviour {

    private PlayerMovement movement;
    private SpriteRenderer spriteRenderer;

    private void Start () {

        movement = GetComponent<PlayerMovement>();

        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public Sprite idleRight, fallRight, landRight;
    public Sprite idleLeft, fallLeft, landLeft;

    public Sprite[] walkRightFrames;
    public Sprite[] walkLeftFrames;
    public Sprite[] jumpRightFrames;
    public Sprite[] jumpLeftFrames;

    public float frameSpeed;

    private float timer;

    public int currentLeftFrameIndex;
    public int currentRightFrameIndex;
    public int currentJumpFrameIndex;

    private bool lastOnGround, lastLeft;

    private void Update () {

        timer -= Time.deltaTime;
        if (timer < 0) timer = frameSpeed; else return;

        if (movement.onGround) {

            if (!lastOnGround) {

                spriteRenderer.sprite = lastLeft ? landLeft : landRight;

            } else if (movement.rightPressed) {

                currentRightFrameIndex++;
                if (currentRightFrameIndex >= walkRightFrames.Length) currentRightFrameIndex = 0;

                spriteRenderer.sprite = walkRightFrames[currentRightFrameIndex];

                currentLeftFrameIndex = -1;

                lastLeft = false;

            } else if (movement.leftPressed) {

                currentLeftFrameIndex++;
                if (currentLeftFrameIndex >= walkLeftFrames.Length) currentLeftFrameIndex = 0;

                spriteRenderer.sprite = walkLeftFrames[currentLeftFrameIndex];

                currentRightFrameIndex = -1;

                lastLeft = true;

            } else {

                spriteRenderer.sprite = lastLeft ? idleLeft : idleRight;
            }

            lastOnGround = true;

            currentJumpFrameIndex = -1;

        } else {

            currentJumpFrameIndex++;
            if (currentJumpFrameIndex >= jumpRightFrames.Length) lastOnGround = false;

            if (lastOnGround) {

                if (movement.leftPressed || lastLeft) {

                    spriteRenderer.sprite = jumpLeftFrames[currentJumpFrameIndex];

                } else {

                    spriteRenderer.sprite = jumpRightFrames[currentJumpFrameIndex];
                }

            } else {

                spriteRenderer.sprite = lastLeft ? fallLeft : fallRight;
            }
        }
    }
}
