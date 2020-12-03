using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverWindow : MonoBehaviour
{
    public Text scoreTextGO;
    public Score score;



    private void Awake()
    {
        scoreTextGO.text = score.scoreCount.ToString();

    }
    private void Update()
    {
        scoreTextGO.text = score.scoreText.text;
    }

    


}
