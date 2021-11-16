using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int score;
    private int time;
    private Home[] homes;
    private Frogger frogger;
    public Text livesText;
    public Text scoreText;
    public Text timeText;

    public GameObject gameOverMenu;

    private void Awake()
    {
        homes = FindObjectsOfType<Home>();
        frogger = FindObjectOfType<Frogger>();
    }
    
    private void Start()
    {
        NewGame();
    }

    /*private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            application.quit;
        }
    }*/

    private void NewGame()
    {
        gameOverMenu.SetActive(false);
        SetScore(0);
        SetTime(60);
        NewLevel();
    }
    
    private void NewLevel()
    {
        for(int i = 0; i < homes.Length; i++)
        {
            homes[i].enabled = false;
        }

        Respawn();
    }

    private void Respawn()
    {
        frogger.Respawn();

        StopAllCoroutines();
        StartCoroutine(Timer(time));
    }

    private IEnumerator Timer(int duration)
    {
        SetTime(duration);

        while (time > 0)
        {
            yield return new WaitForSeconds(1);

            time--;
            timeText.text = time.ToString();
        }

        frogger.Death();
    }

    public void Died()
    {
        SetTime(time - 10);

        if (time > 0)
        {
            Invoke(nameof(Respawn), 1f);
        }
        else
        {
            Invoke(nameof(GameOver), 1f);
        }
    }

    private void GameOver()
    {
        frogger.gameObject.SetActive(false);
        gameOverMenu.SetActive(true);

        StopAllCoroutines();
        StartCoroutine(PlayAgain());
    }

    private IEnumerator PlayAgain()
    {
        bool playAgain = false;

        while (!playAgain)
        {
            if(Input.GetKeyDown(KeyCode.Return))
            {
                playAgain = true;
            }
            yield return null;
        }

        NewGame();
    }

    public void AdvancedRow()
    {
        SetScore(score + 10);
    }

    public void HomeOccupied()
    {
        frogger.gameObject.SetActive(false);

        int bonusPoints = time * 20;
        SetScore(score + bonusPoints + 50);

        if (Cleared())
        {
            SetScore(score + 1000);
            Invoke(nameof(NewLevel), 1f);
            SetTime(time + 60);
        }
        else
        {
            Invoke(nameof(Respawn), 1f);
            SetTime(time + 15);
        }
    }

    private bool Cleared()
    {
        bool returnBool = true;
        for(int i = 0; i < homes.Length; i++)
        {
            if(!homes[i].enabled)
            {
                returnBool = false;
            }
        }
        return returnBool;
    }

    private void SetScore(int score)
    {
        this.score = score;
        scoreText.text = score.ToString();
    }

    private void SetTime(int time)
    {
        this.time = time;
        if(time > 0)
        {
            timeText.text = time.ToString();
        }
        else
        {
            timeText.text = "0";
        }
        
    }

}
