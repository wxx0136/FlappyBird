using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject main;
    public GameObject tutorial;
    public GameObject score;

    public GameObject bird;

    public bool isGameReady = false;
    public bool isGameStart = false;

    public void PlayBtnClick()
    {
        main.GetComponent<UIManager>().HideUI();
        tutorial.GetComponent<UIManager>().ShowUI();
        score.GetComponent<UIManager>().ShowUI();
        isGameReady = true;
    }

    private void Update()
    {
        if (!isGameReady) return;
        if (isGameStart) return;

        if (Input.GetMouseButtonDown(0))
        {
            tutorial.GetComponent<UIManager>().HideUI();
            bird.GetComponent<BirdFly>().ChangeState(true);
            isGameStart = true;
        }
        
    }
}
