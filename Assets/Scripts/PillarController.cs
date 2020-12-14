using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarController : MonoBehaviour
{
    public Transform pipesTransform;
    public GameObject pipePrefab;

    public GameManager gameManager;
    private IEnumerator _spawnPipesEnumerator;

    public float spawnTime = 1.9f;

    private List<GameObject> _pipes = new List<GameObject>();
    public bool isMoving = true;

    public void Start()
    {
        _spawnPipesEnumerator = SpawnPipes();
        StartCoroutine(_spawnPipesEnumerator);
    }

    public void StartMove()
    {
        isMoving = true;
        foreach (var item in _pipes)
        {
            item.GetComponent<PipeScript>().canMove = true;
        }
    }

    public void StopMove()
    {
        isMoving = false;
        foreach (var item in _pipes)
        {
            item.GetComponent<PipeScript>().canMove = false;
        }
    }

    private void SpawnOnePipe()
    {
        var newPipe = Instantiate(pipePrefab, pipesTransform);
        newPipe.GetComponent<PipeScript>().RandomHeightOfPipes();
        _pipes.Add(newPipe);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            StopMove();
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            StartMove();
        }
    }

    private IEnumerator SpawnPipes()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnTime);

            if (!gameManager.isGameStart) continue;
            if (!isMoving) continue;
            SpawnOnePipe();
        }
    }
}