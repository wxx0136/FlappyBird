using UnityEngine;

public class BirdFly : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public Animator animator;

    public GameManager gameManager;
    private static readonly int State = Animator.StringToHash("state");

    // Start is called before the first frame update
    void Start()
    {
        animator.SetInteger(State, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameManager.isGameStart) return;

        if (Input.GetMouseButtonDown(0))
        {
            rb2d.velocity = new Vector2(0, 8);
        }
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
