using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgController : MonoBehaviour
{
    Vector3 start_postion;
    public float speed = -0.02f;
    public float set_off = 0f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
        start_postion = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -11.4f + set_off)
        {
            transform.position = start_postion;
        }
        transform.Translate(speed, 0, 0);
    }
}
