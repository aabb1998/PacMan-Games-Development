using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;

public class PacStudentController : MonoBehaviour
{

    // control the speed of movement
    // public float speed = 0.3f;
    // Vector2 dest = Vector2.zero;

    // bool obstacle(Vector2 dir) {
    //     Vector2 pos = transform.position;
    //     RaycastHit2D impact = Physics2D.Linecast(pos + dir, pos);
    //     return (impact.collider == GetComponent<Collider2D>());
    // }
    public Transform[] waypoints;
    int cur = 0;
    public float speed = 0.3f;
    public int startDelay = 30000;
    Animator animator;
    Vector2 dest = Vector2.zero;

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
            if (Input.GetKey(KeyCode.D) && valid(Vector2.right))
                dest = (Vector2)transform.position + Vector2.right;
            if (Input.GetKey(KeyCode.S) && valid(-Vector2.up))
                dest = (Vector2)transform.position - Vector2.up;
            if (Input.GetKey(KeyCode.A) && valid(-Vector2.right))
                dest = (Vector2)transform.position - Vector2.right;
        }

        // Animation Parameters
        Vector2 dir = dest - (Vector2)transform.position;
        GetComponent<Animator>().SetFloat("DirX", dir.x);
        GetComponent<Animator>().SetFloat("DirY", dir.y);
    }
        // Update is called once per frame
        // void FixedUpdate()
        // {
            

        // if (transform.position != waypoints[cur].position) {
        //     Vector2 p = Vector2.MoveTowards(transform.position,
        //                                     waypoints[cur].position,
        //                                     speed);
        //     GetComponent<Rigidbody2D>().MovePosition(p);
        //  }
        //     // Waypoint reached, select next one
        //     else cur = (cur + 1) % waypoints.Length;

        //     Vector2 dir = waypoints[cur].position - transform.position;
        //     GetComponent<Animator>().SetFloat("DirX", dir.x);
        //     GetComponent<Animator>().SetFloat("DirY", dir.y);
        //     Vector2 p = Vector2.MoveTowards(transformF.position, dest, speed);
        //     GetComponent<Rigidbody2D>().MovePosition(p);

        //     if ((Vector2)transform.position == dest) {
        //         if (Input.GetKey(KeyCode.UpArrow) && valid(Vector2.up))
        //             dest = (Vector2)transform.position + Vector2.up;
        //         if (Input.GetKey(KeyCode.RightArrow) && valid(Vector2.right))
        //             dest = (Vector2)transform.position + Vector2.right;
        //         if (Input.GetKey(KeyCode.DownArrow) && valid(-Vector2.down))
        //             dest = (Vector2)transform.position + Vector2.down;
        //         if (Input.GetKey(KeyCode.LeftArrow) && valid(-Vector2.left))
        //             dest = (Vector2)transform.position + Vector2.left;
        //     }

        //     Vector2 dir = dest - (Vector2)transform.position;
        //     GetComponent<Animator>().SetFloat("DirX", dir.x);
        //     GetComponent<Animator>().SetFloat("DirY", dir.y);


        
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

