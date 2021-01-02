using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject main;
    public GameObject tutorial;
    public GameObject score;

    public GameObject bird;

    public bool isGameReady;
    public bool isGameStart;
    private UIManager _uiManager;
    private BirdFly _birdFly;

    private void Start()
    {
        _birdFly = bird.GetComponent<BirdFly>();
        _uiManager = tutorial.GetComponent<UIManager>();
    }

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
            _uiManager.HideUI();
            _birdFly.ChangeState(true);
            _birdFly.Fly();
            isGameStart = true;
        }
    }

    public void GameOver()
    {
        isGameReady = false;
        isGameStart = false;
        
        GameObject.Find("PillarController").GetComponent<PillarController>().StopMove();
        GameObject.Find("bg_container").GetComponent<BgController>().isMove = false;
    }

    public void GetScore()
    {
        
    }
}