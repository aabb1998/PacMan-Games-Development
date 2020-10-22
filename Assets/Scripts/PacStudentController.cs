using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;
using UnityEngine.UI;


public class PacStudentController : MonoBehaviour
{


    public Transform[] waypoints;
    int cur = 0;
    public float speed = 0.3f;
    public int startDelay = 30000;
    Animator animator;
    Vector2 dest = Vector2.zero;
    public float SpawnRate = 1f;
    private float DelayTimer = 5f;
    public Text scoreText;
    

    private static int startingScore = 0;
    private int currentScore = 0;

    private static int pelletScore = 10;
    private static int powerPelletScore = 50;
    private static int powerCheeryScore = 100;

    public int livesAmount = 3;
    public int currentLives = 3;

    AudioSource source;
    public AudioClip pelletEat;

    // Store the last key pressed by the user
    KeyCode lastInput;


    // Start is called before the first frame update
    void Start()
    {
        dest = transform.position;
        currentScore = startingScore;
        source = GetComponent<AudioSource>();
    }

    public void increaseScore(int addScore) {
        currentScore += addScore;
        //timerText.text = minutes + ":" + seconds + ":" + ms;
        scoreText.text = "Score: " + currentScore;
    }

    void Update() {
        // Move closer to Destination
        Vector2 p = Vector2.MoveTowards(transform.position, dest, speed);
        GetComponent<Rigidbody2D>().MovePosition(p);

        // Check for Input if not moving
        if ((Vector2)transform.position == dest && Time.time > DelayTimer) {
            if (Input.GetKey(KeyCode.W) && valid(Vector2.up) && Time.time > DelayTimer)
                dest = (Vector2)transform.position + Vector2.up;
                lastInput = KeyCode.W;
                // print(lastKey);
            if (Input.GetKey(KeyCode.D) && valid(Vector2.right) && Time.time > DelayTimer)
                dest = (Vector2)transform.position + Vector2.right;
                lastInput = KeyCode.D;
                                // print(lastKey);

            if (Input.GetKey(KeyCode.S) && valid(-Vector2.up) && Time.time > DelayTimer)
                dest = (Vector2)transform.position - Vector2.up;
                lastInput = KeyCode.S;
                                // print(lastKey);

            if (Input.GetKey(KeyCode.A) && valid(-Vector2.right) && Time.time > DelayTimer)
                dest = (Vector2)transform.position - Vector2.right;
                lastInput = KeyCode.A;
                                // print(lastKey);

        }

        print(lastInput);

        // Animation Parameters
        Vector2 dir = dest - (Vector2)transform.position;
        GetComponent<Animator>().SetFloat("DirX", dir.x);
        GetComponent<Animator>().SetFloat("DirY", dir.y);
    }


        void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("pellet")) 
            print("HELLO");
            Destroy(collision.gameObject);
            increaseScore(pelletScore);
            source.PlayOneShot(pelletEat,0.3f);

        } 
        

        bool valid(Vector2 dir) {
            Vector2 pos = transform.position;
            RaycastHit2D hit = Physics2D.Linecast(pos + dir, pos);
            return (hit.collider == GetComponent<Collider2D>());
        }
}

