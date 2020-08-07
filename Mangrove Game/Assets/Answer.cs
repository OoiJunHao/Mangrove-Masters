using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Answer : MonoBehaviour
{
    public bool answer;
    public AudioSource sound;
    public GameObject itself;
    public string losepage;
    public int qnNumber;
    void Start() {
        if(SceneManager.GetActiveScene().name == "StartPage") {
            Destroy(gameObject);
        }
    }

    void Update() {        
    }      

    void OnMouseDown() {
        sound.Play();
        if (answer) {
            Destroy(itself);
            Tracker.IncrementTracker();
        } else {
            DataBox.databox = qnNumber;
            SceneManager.LoadScene(losepage);
        }
    }   
}