using UnityEngine;
using DG.Tweening;

public class BirdFly : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public Animator animator;

    public GameManager gameManager;
    private static readonly int State = Animator.StringToHash("state");

    public Transform birdSpriteTransform;
    public float rotating = 4f;
    public float birdSpeed = 6.5f;

    private void Start()
    {
        animator.SetInteger(State, 1);
    }

    private void Update()
    {
        if (!gameManager.isGameStart) return;

        if (Input.GetMouseButtonDown(0))
        {
            Fly();
        }

        birdSpriteTransform.transform.DORotateQuaternion(Quaternion.Euler(0, 0, rb2d.velocity.y * rotating), 0.3f);
    }

    public void Fly()
    {
        rb2d.velocity = new Vector2(0, birdSpeed);
    }


    public void ChangeState(bool isFlying, bool isSim = false)
    {
        if (isFlying)
        {
            animator.SetInteger(State, 0);
        }
        else
        {
            animator.SetInteger(State, 1);
        }

        rb2d.simulated = isSim;
    }
}