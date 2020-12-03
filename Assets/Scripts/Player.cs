using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    private Rigidbody2D rb;
    public float upForce;
    public GameObject gameOverWindow;
    private Animator animator;
    private string currentAnimation;
    private bool isDead;
    private AudioSource audioSource;
    [SerializeField] private AudioClip fallClip;
    [SerializeField] private AudioClip hitClip;





    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }



    void Update()
    {
        if (isDead == false)
        {
            if (Input.GetMouseButtonUp(0))
            {
                rb.velocity = Vector2.zero;
                rb.AddForce(new Vector2(0, upForce));
            }
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
                audioSource.PlayOneShot(hitClip);
                Lose();
                break;

        }
    }

   public void Lose()
    {
        isDead = true;
        rb.velocity = Vector2.zero;
        Invoke("GamePause", 1f);
        rb.velocity = Vector2.zero;
        gameOverWindow.SetActive(true);
        ChangeAnimation("Hurt");
        Invoke("PlayDeathAnimation", 1f);

        

    }

    private void PlayDeathAnimation()
    {
        animator.SetTrigger("Death");
        audioSource.PlayOneShot(fallClip);

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
