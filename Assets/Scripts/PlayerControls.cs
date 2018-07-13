using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerControls : MonoBehaviour {
    [SerializeField]float speed = 10f;
    [SerializeField] float jumpSpeed = 20f;
    [SerializeField] float timeDivision = 5;
    private bool isGrounded = true;
    private Rigidbody2D rb;
    private Animator anim;
    public bool isDead = false;
    private float score = 0;
    public Text scoreText;
    public GameObject gameOverText;
    private int currentScene;
    AudioSource audioSource;
    public AudioClip jump;
    public AudioClip dead;
    public AudioClip scoreSFX;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        currentScene = SceneManager.GetActiveScene().buildIndex;
        audioSource = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        if (isDead == false)
        {
            CheckScore();
            if (Input.GetMouseButtonDown(0) && isGrounded)
            {
                Jump();
            }
        }
        else if (isDead == true && Input.GetMouseButtonDown(0)) {
            SceneManager.LoadScene(currentScene);
        }
        else
        {
            return;
        }
	}

    private void CheckScore() {
        score++;
        //slow the time score by division
        scoreText.text = "Score: " + (score/timeDivision).ToString();
        if (score % 500 == 0) {
            audioSource.PlayOneShot(scoreSFX, 1f);
        }
    }
    private void Run() {
        transform.Translate(transform.right * speed * Time.deltaTime);
    }

    private void Jump() {
        rb.velocity = new Vector2(0, jumpSpeed);
        isGrounded = false;
        audioSource.PlayOneShot(jump, 1f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "background") {
            isGrounded = true;
        }

        if (collision.gameObject.tag == "obstacle")
        {
            Die();
        }

    }

    private void Die() {
        isDead = true;
        anim.SetTrigger("dead");
        gameOverText.SetActive(true);
        audioSource.PlayOneShot(jump, 1f);

    }
    //anytime die, detect input and reload current scene

}
