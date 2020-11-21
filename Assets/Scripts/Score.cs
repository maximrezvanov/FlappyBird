using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public int scoreCount;
    public Text scoreText;



    private void Start()
    {
        scoreCount = 0;

    }

    private void Update()
    {
        scoreText.text = scoreCount.ToString();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Score"))
        {
            scoreCount++;
        }
    }

}
