using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;

public class PacStudentController : MonoBehaviour
{


    public Transform[] waypoints;
    int cur = 0;
    public float speed = 0.3f;
    public int startDelay = 30000;
    Animator animator;
    Vector2 dest = Vector2.zero;

    // Store the last key pressed by the user
    KeyCode lastKey;


    // Start is called before the first frame update
    void Start()
    {
        dest = transform.position;
        // animator = GetComponent<Animator>();
        // StartCoroutine(DelayedAnimation());
    }

    // IEnumerator DelayedAnimation () {
    //     yield return new WaitForSeconds(startDelay);
    //     animator.Play("PacManAnim");
    // }

    void FixedUpdate() {
        // Move closer to Destination
        Vector2 p = Vector2.MoveTowards(transform.position, dest, speed);
        GetComponent<Rigidbody2D>().MovePosition(p);

        // Check for Input if not moving
        if ((Vector2)transform.position == dest) {
            if (Input.GetKey(KeyCode.W) && valid(Vector2.up))
                dest = (Vector2)transform.position + Vector2.up;
                lastKey = KeyCode.W;
                // print(lastKey);
            if (Input.GetKey(KeyCode.D) && valid(Vector2.right))
                dest = (Vector2)transform.position + Vector2.right;
                lastKey = KeyCode.D;
                                // print(lastKey);

            if (Input.GetKey(KeyCode.S) && valid(-Vector2.up))
                dest = (Vector2)transform.position - Vector2.up;
                lastKey = KeyCode.S;
                                // print(lastKey);

            if (Input.GetKey(KeyCode.A) && valid(-Vector2.right))
                dest = (Vector2)transform.position - Vector2.right;
                lastKey = KeyCode.A;
                                // print(lastKey);

        }

        print(lastKey);
        // if (lastKey == KeyCode.W) {
        //     print("W was pressed");
        // }
        // if (lastKey == KeyCode.D) {
        //     print("D was pressed");
        // }
        // if (lastKey == KeyCode.S) {
        //     print("S was pressed");
        // }
        // if (lastKey == KeyCode.A) {
        //     print("A was pressed");
        // }

        // while (true) {
        //     if ((Vector2)transform.position == dest) {
        //         if (Input.GetKey(KeyCode.W) && valid(Vector2.up))
        //             dest = (Vector2)transform.position + Vector2.up;
        //             lastKey = KeyCode.W;
        //     }
        // }

        // Animation Parameters
        Vector2 dir = dest - (Vector2)transform.position;
        GetComponent<Animator>().SetFloat("DirX", dir.x);
        GetComponent<Animator>().SetFloat("DirY", dir.y);
    }


        void OnTriggerEnter2D(Collider2D co) {
        // if (co.name == "pacman")
        //     Destroy(co.gameObject);
        }

        bool valid(Vector2 dir) {
            Vector2 pos = transform.position;
            RaycastHit2D hit = Physics2D.Linecast(pos + dir, pos);
            return (hit.collider == GetComponent<Collider2D>());
        }
}

