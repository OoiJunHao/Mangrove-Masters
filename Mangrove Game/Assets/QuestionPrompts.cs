using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class QuestionPrompts : MonoBehaviour
{
    public GameObject target;
    public float speed;
    public GameObject itself;
    public AudioSource sound;
    public float xAxis;
    public float yAxis;
    public bool leftRightRandom;
    public string losingpage;
    public bool wavy;
    float delta = 0.02f;
    float speeds = 4.0f; 
    public float magnitude = 1.0f;
    
    void Start() { 
        if (leftRightRandom) {
            transform.position = new Vector3(Random.Range(xAxis-12, xAxis+12), yAxis -1f);
        } else {
            transform.position = new Vector3(xAxis, Random.Range(yAxis-7, yAxis+7), -1f);
        }
    }
    
    void Update() {
        if (wavy) {
        Vector3 startPos = transform.position;
        Vector3 v = startPos;
         v.x += magnitude*delta * Mathf.Sin (Time.time * speeds);
         v.y += magnitude*delta * Mathf.Sin (Time.time * speeds);
         transform.position = v;
        }
       transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed); 
        if (transform.position.Equals(target.transform.position)) {
            DataBox.databox = 0;
            SceneManager.LoadScene(losingpage);
        } 
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }

    void OnMouseDown() {
        sound.Play();
        Destroy(itself);
        Random random = new Random();
        bool done = false;
        while (!done) {
            int qn = Random.Range(1, 10); //Number of question +1
            if (GameObject.Find("Question"+qn) != null) {
                GameObject quest = GameObject.Find("Question"+qn);
                quest.transform.position = target.transform.position;
                done = true;
                //Debug.Log("Hit Question: " + qn);
            }
        }
    }
}

