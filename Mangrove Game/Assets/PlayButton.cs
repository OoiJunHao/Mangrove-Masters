using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public string destination;
    public AudioSource sound;

    void Start() {       
    }

    void Update() {
     if (Input.GetKey("escape")) {
            Application.Quit();
        }   
    }

    void OnMouseDown() {
            sound.Play();
            SceneManager.LoadScene(destination);
    }
}


