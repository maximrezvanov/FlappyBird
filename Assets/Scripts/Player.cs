using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public Rigidbody2D rbb;
    public float force;
    public GameObject gameOverWindow;
    private Animator animator;
    private string currentAnimation;


    enum State { Playing, Dead };

    State state = State.Playing;



    void Start()
    {
        rbb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        state = State.Playing;

    }



    void Update()
    {
        Control();
    }

    void Control()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rbb.AddForce(Vector2.up * force * Time.deltaTime, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Bonus":
                break;
            case "Score":
                break;
            default:
                Lose();
                break;

        }
    }

   public void Lose()
    {
        state = State.Dead;
        Invoke("GamePause", 3f);
        force = 0;
        gameOverWindow.SetActive(true);
        ChangeAnimation("Hurt");
        Invoke("PlayDeathAnimation", 1.5f);

    }

    private void PlayDeathAnimation()
    {
        animator.SetTrigger("Death");
    }

    

  public void ChangeAnimation(string animation)
    {
        if (animation == currentAnimation) return;
        
            animator.Play(animation);
            currentAnimation = animation;
        
    }

    public void GamePause()
    {
        if (Time.timeScale > 0)
        {
            gameOverWindow.SetActive(true);
            Time.timeScale = 0;

        }
        else
        {
            Time.timeScale = 1;
            gameOverWindow.SetActive(true);

        }
    }

}
