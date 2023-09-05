using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public GameObject winCanvas;
    public void Start()
    {
        Time.timeScale = 1 ;
    }
    
    public void gameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }
    public void win()
    {
        winCanvas.SetActive(true);
        Time.timeScale = 0;
    }
    public void Update()
    {
        if (Score.score == 20)
            win();
    }
}
