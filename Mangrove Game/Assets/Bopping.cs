using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bopping : MonoBehaviour
{
    public float delta = 0.12f;
    public float speed = 8.0f; 
    public float magnitude = 1.0f;
     private Vector3 startPos;
 
     void Start () {
         startPos = transform.position;
     }
     
     void Update () {
         Vector3 v = startPos;
         v.y += magnitude*delta * Mathf.Sin (Time.time * speed);
         transform.position = v;
     }
}
