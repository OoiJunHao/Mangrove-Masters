using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tracker : MonoBehaviour
{
    public static int tracker;
    public string nextScene;
    public int noOfWins;
    void Start()
    {
        Tracker.tracker = 0;
    }

    public static void IncrementTracker() {
        tracker++;
    }

    // Update is called once per frame
    void Update() {
        if (Tracker.tracker == noOfWins) {
            SceneManager.LoadScene(nextScene);
        }
    }
}
