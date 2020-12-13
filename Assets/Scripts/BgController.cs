using UnityEngine;

public class BgController : MonoBehaviour
{
    private Vector3 _startPosition;
    public float speed = -0.02f;
    public float setOff;

    // Start is called before the first frame update
    private void Start()
    {
        _startPosition = transform.position;
    }

    // Update is called once per frame
    private void Update()
    {
        if (transform.position.x < -11.4f + setOff)
        {
            transform.position = _startPosition;
        }

        transform.Translate(speed, 0, 0);
    }
}