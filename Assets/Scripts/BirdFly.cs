using UnityEngine;

public class BirdFly : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public Animator animator;

    public GameManager gameManager;
    private static readonly int State = Animator.StringToHash("state");

    public Transform birdSpriteTransform;
    public float rotating = 4f;

    private void Start()
    {
        animator.SetInteger(State, 1);
    }

    private void Update()
    {
        if (!gameManager.isGameStart) return;

        if (Input.GetMouseButtonDown(0))
        {
            rb2d.velocity = new Vector2(0, 8);
        }

        birdSpriteTransform.rotation = Quaternion.Euler(0, 0, rb2d.velocity.y * rotating);
    }

    public void ChangeState(bool isFlying)
    {
        if (isFlying)
        {
            animator.SetInteger(State, 0);
            rb2d.simulated = true;
        }
        else
        {
            animator.SetInteger(State, 1);
            rb2d.simulated = false;
        }
    }
}