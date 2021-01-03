using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject main;
    public GameObject tutorial;
    public GameObject score;
    public GameObject gameOverPanel;

    public GameObject bird;

    public bool isGameReady;
    public bool isGameStart;
    private UIManager _uiManager;
    private BirdFly _birdFly;

    public Text scoreText;

    public Text currentScoreText;
    public Text bestScoreText;
    public GameObject newScore;
    public Image medal;
    public List<Sprite> medals;

    private void Start()
    {
        _birdFly = bird.GetComponent<BirdFly>();
    }

    public void PlayBtnClick()
    {
        Tools.Instance.HideUI(main);
        Tools.Instance.ShowUI(tutorial);
        Tools.Instance.ShowUI(score);

        _birdFly.ChangeState(true);
        isGameReady = true;
    }

    private void Update()
    {
        if (!isGameReady) return;
        if (isGameStart) return;

        if (Input.GetMouseButtonDown(0))
        {
            Tools.Instance.HideUI(tutorial);

            _birdFly.ChangeState(true, true);
            _birdFly.Fly();
            isGameStart = true;
        }
    }

    public void GameOver()
    {
        if (!isGameStart) return;

        isGameReady = false;
        isGameStart = false;

        GameObject.Find("PillarController").GetComponent<PillarController>().StopMove();
        GameObject.Find("BGContainer").GetComponent<BgController>().isMove = false;

        Tools.Instance.ShowUI(gameOverPanel);
        Tools.Instance.HideUI(score);

        var i = int.Parse(scoreText.text);

        if (i >= 15)
        {
            medal.sprite = medals[3];
        }
        else if (i >= 10)
        {
            medal.sprite = medals[2];
        }
        else if (i >= 5)
        {
            medal.sprite = medals[1];
        }
        else
        {
            medal.sprite = medals[0];
        }

        if (PlayerPrefs.GetInt("bestScore") < i)
        {
            PlayerPrefs.SetInt("bestScore", i);
            newScore.SetActive(true);
        }

        currentScoreText.text = i.ToString();
        bestScoreText.text = PlayerPrefs.GetInt("bestScore").ToString();
    }

    public void GetScore()
    {
        scoreText.text = (int.Parse(scoreText.text) + 1).ToString();
    }

    public void Restart()
    {
        SceneManager.LoadScene("GameScene");
    }
}