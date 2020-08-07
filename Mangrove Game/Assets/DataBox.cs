using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DataBox : MonoBehaviour
{
    public static int databox;
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
         if(SceneManager.GetActiveScene().name == "StartPage") {
         Destroy(gameObject);
    }
    }

}
