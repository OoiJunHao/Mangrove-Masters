using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Sound : MonoBehaviour
{
 public AudioSource sound;
  void Awake() {         
    int numMusicPlayers = FindObjectsOfType<AudioSource>().Length;
     if (numMusicPlayers == 3) {
         Destroy(this.gameObject);
     } else {
      DontDestroyOnLoad(gameObject);
      sound.Play();
     }
    }
 void Update () {
     if(SceneManager.GetActiveScene().name == "Phase1Start") {
         sound.Stop();
         Destroy(gameObject);
     }
 }
}
