using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplainationPop : MonoBehaviour
{
    public GameObject one;
    public GameObject two;
    public GameObject three;
    public GameObject four;
    public GameObject five;
    public GameObject six;
    public GameObject seven;
    public GameObject eight;
    public GameObject zero;
    
    void Start() {      
        if (DataBox.databox == 1) {
            one.transform.position = new Vector3(0f, 3.63f, 0f);
        } else if (DataBox.databox == 2) {
            two.transform.position = new Vector3(0f, 3.63f, 0f);
        } else if (DataBox.databox == 3) {
            three.transform.position = new Vector3(0f, 3.63f, 0f);
        } else if (DataBox.databox == 4) {
            four.transform.position = new Vector3(0f, 3.63f, 0f);
        } else if (DataBox.databox == 5) {
            five.transform.position = new Vector3(0f, 3.63f, 0f);
        } else if (DataBox.databox == 6) {
            six.transform.position = new Vector3(0f, 3.63f, 0f);
        } else if (DataBox.databox == 7) {
            seven.transform.position = new Vector3(0f, 3.63f, 0f);
        } else if (DataBox.databox == 8) {
            eight.transform.position = new Vector3(0f, 3.63f, 0f);
        } else if (DataBox.databox == 0) {
            zero.transform.position = new Vector3(0f, 3.63f, 0f);
        }
    }

    void Update() {       
    }
}
