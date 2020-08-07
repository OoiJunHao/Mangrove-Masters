using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerTrigger : MonoBehaviour
{
    public AudioSource dangerWarning;
    public bool warningSignal = false;

    void Start() {
    }

    void Update() {
        Collider[] hit = Physics.OverlapSphere(new Vector3(0.023f, 0.02f, 0f), 1f);
        if (hit.Length != 0 && !warningSignal){
            dangerWarning.Play();
            warningSignal = true;
        }
        if (hit.Length == 0 && warningSignal) {
            dangerWarning.Stop();
            warningSignal = false;
        }
        Debug.Log(hit.Length);
    }
}