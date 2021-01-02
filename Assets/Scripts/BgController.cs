using UnityEngine;

public class BgController : MonoBehaviour
{
    private Vector3 _startPosition;
    public float speed = -0.02f;
    public float setOff;
    public bool isMove = true;

    private void Start()
    {
        _startPosition = transform.position;
    }

    private void Update()
    {
        if (!isMove) return;

        if (transform.position.x < -11.4f + setOff)
        {
            transform.position = _startPosition;
        }

        transform.Translate(speed, 0, 0);
    }
}