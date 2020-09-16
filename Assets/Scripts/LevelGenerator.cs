
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LevelGenerator : MonoBehaviour
{

    //public GameObject mazeEmpty;
    //public GameObject PacManSpriteRight;
    // public GameObject PacManSpriteLeft;
    public GameObject MazeLeftCorner;
    public GameObject MazeRightCorner;
    // public GameObject MazeBottomLeftCorner;
    // public GameObject MazeBottomRightCorner;

    public Camera mainCam;


    
    int[,] levelMap =
    {
        {1,2,2,2,2,2,2,2,2,2,2,2,2,7},
        {2,5,5,5,5,5,5,5,5,5,5,5,5,4},
        {2,5,3,4,4,3,5,3,4,4,4,3,5,4},
        {2,6,4,0,0,4,5,4,0,0,0,4,5,4},
        {2,5,3,4,4,3,5,3,4,4,4,3,5,3},
        {2,5,5,5,5,5,5,5,5,5,5,5,5,5},
        {2,5,3,4,4,3,5,3,3,5,3,4,4,4},
        {2,5,3,4,4,3,5,4,4,5,3,4,4,3},
        {2,5,5,5,5,5,5,4,4,5,5,5,5,4},
        {1,2,2,2,2,1,5,4,3,4,4,3,0,4},
        {0,0,0,0,0,2,5,4,3,4,4,3,0,3},
        {0,0,0,0,0,2,5,4,4,0,0,0,0,0},
        {0,0,0,0,0,2,5,4,4,0,3,4,4,0},
        {2,2,2,2,2,1,5,3,3,0,4,0,0,0},
        {0,0,0,0,0,0,5,0,0,0,4,0,0,0},
    }; 




    // Start is called before the first frame update
    void Start()
    {

        Bounds bound = MazeLeftCorner.GetComponent<Renderer>().bounds;
        mainCam.orthographicSize = 18 * bound.size.y * 0.5f;

         int rowLength = levelMap.GetLength(0);
         int colLength = levelMap.GetLength(1);

        Vector3 pos = mainCam.ScreenToWorldPoint(Vector3.zero);
        pos = new Vector3( pos.x + bound.extents.x, pos.y + bound.extents.y, 0);
        Vector3 nextPosition = pos;

        

        for (int i = 0; i < rowLength; i++) {

            for (int j = 0; j < colLength; j++) {

                // arrayString += string.Format("{0} ", levelMap[i, j]);
                if (levelMap[i,j] == 1) {
                    GameObject a = Instantiate(MazeLeftCorner, new Vector3(nextPosition.x,nextPosition.y,0), Quaternion.identity);
                    nextPosition = new Vector3(pos.x+(MazeLeftCorner.GetComponent<Renderer>().bounds.size.x)*i, pos.y+(MazeLeftCorner.GetComponent<Renderer>().bounds.size.y)*j,0);
                }
                else if (levelMap[i,j] == 2) {
                    GameObject b = Instantiate(MazeRightCorner, new Vector3(nextPosition.x,nextPosition.y,0), Quaternion.identity);
                    nextPosition = new Vector3(pos.x+(MazeLeftCorner.GetComponent<Renderer>().bounds.size.x)*i, pos.y+(MazeLeftCorner.GetComponent<Renderer>().bounds.size.y)*j,0);
                }
            }

            // arrayString += System.Environment.NewLine + System.Environment.NewLine;
        }
        //Debug.Log(arrayString);
        
        // Instantiate(MazeLeftCorner);
        // //Instantiate(PacManSpriteRight);




        //  int rowLength = levelMap.GetLength(0);
        //  int colLength = levelMap.GetLength(1);
        // string arrayString = "";
        
        // for (int i = 0; i < rowLength; i++) {

        //     for (int j = 0; j < colLength; j++) {

        //         // arrayString += string.Format("{0} ", levelMap[i, j]);
        //         if (levelMap[i,j] == 1) {
        //             Instantiate(MazeLeftCorner, transform.position, transform.rotation);
        //         }
        //     }

        //     // arrayString += System.Environment.NewLine + System.Environment.NewLine;
        // }
        // //Debug.Log(arrayString);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
