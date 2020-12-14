using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarController : MonoBehaviour
{
    public Transform pipes;
    public GameObject pipePrefab;

    public void StartMove()
    {
    }

    public void StopMOve()
    {
    }

    public void SpawnOnePipe()
    {
        var newPipe = Instantiate(pipePrefab, pipes);
        newPipe.GetComponent<PipeScript>().RandomHeightOfPipes();
    }
}