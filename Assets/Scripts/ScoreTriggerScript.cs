using UnityEngine;

public class ScoreTriggerScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject.Find("GameManager").GetComponent<GameManager>().GetScore();
    }
}