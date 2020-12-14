using UnityEngine;
using Random = UnityEngine.Random;

public class PipeScript : MonoBehaviour
{
    public float speed = 0.05f;
    public bool canMove = true;

    public void FixedUpdate()
    {
        if (!canMove) return;

        transform.Translate(-speed, 0, 0);
    }

    public void RandomHeightOfPipes()
    {
        var ran = Random.Range(-1.8f, 2.5f);
        transform.SetPositionAndRotation(new Vector3(transform.position.x, ran, transform.position.z),
            transform.rotation);
    }

    public void Update()
    {
    }
}