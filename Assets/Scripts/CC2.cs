using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class CC2 : MonoBehaviour {

public Sprite sprite;

GameObject gameObject;  
SpriteRenderer spriteRenderer;
Vector3 startPosition;
Vector3 targetPosition;
float t;

void Awake()
{
    gameObject = new GameObject();
    spriteRenderer = gameObject.AddComponent<SpriteRenderer>();        
}

private void Start()
{
    spriteRenderer.sprite = sprite;
    startPosition  = new Vector3(-35, 42, 0);
    targetPosition = new Vector3(139, 42, 0);        
}
    
void Update()
{        
    t += Time.deltaTime*0.1f;
    transform.position = Vector3.Lerp(startPosition, targetPosition , t);
}

}