using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdFly : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator.SetInteger("state", 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb2d.velocity = new Vector2(0, 8);
        }
    }
}
