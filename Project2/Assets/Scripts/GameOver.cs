using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOver : MonoBehaviour
{
    public TMP_Text gameOverTxt;

    [SerializeField]
    GameObject gameOverPrefab;
    private GameObject gameOver;

    [SerializeField]
    GameObject bigBoyPrefab;

    public GameObject player;

    void Update()
    {
       

        if (!player && !gameOver)
            gameOver = Instantiate(gameOverPrefab) as GameObject;
        gameOverTxt.text = "Game Over";
    }
}
