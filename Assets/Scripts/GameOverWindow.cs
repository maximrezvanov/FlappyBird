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
        Hide();

    }

    private void Start()
    {
        scoreTextGO.text = null;

    }
    private void Update()
    {
        scoreTextGO.text = score.scoreText.text;
            }

    public void Hide()
    {
        gameObject.SetActive(false);
    }

    public void Show()
    {
        gameObject.SetActive(transform);
    }

    //public void BirdDied(Player player)
    //{
    //    scoreTextGO.text = score.scoreText.text;


    //}
  
}
