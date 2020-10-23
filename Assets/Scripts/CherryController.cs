using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class CherryController : MonoBehaviour
{
    [SerializeField] [Range(0f,4f)] float lerpTime;
    [SerializeField] Vector3[] myPositions;
    int posIndex = 0;
    int length;
    float t = 0f;
    Vector3 cherrySpeed;
    public float Timer = 3;
    public GameObject cherry;


    // Start is called before the first frame update
    void Start()
    {
        cherrySpeed = (new Vector3 (0, Random.Range(5,10), 0));
        length = myPositions.Length;
    }

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0) {
            Rigidbody2D cherryClone;
            cherryClone =((GameObject)Instantiate(cherry,(new Vector3 (-34,42,10)), transform.rotation)).GetComponent<Rigidbody2D>();
            cherryClone.AddForce(cherrySpeed);
            Timer = 30;
            // transform.position = Vector3.Lerp(transform.position, myPositions[posIndex], lerpTime * Time.deltaTime);
            // t = Mathf.Lerp(t,1f,lerpTime * Time.deltaTime);
            // if (t > .9f) {
            //     t = 0f;
            //     posIndex++;
            //     posIndex = (posIndex >= length) ? 0: posIndex;
            // }
            Destroy(cherryClone.gameObject, 10f);
            
        }
    }
}



