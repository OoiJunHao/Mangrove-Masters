using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigSmall : MonoBehaviour
{
    public float scaleRate  = 0.01f;
    public float minScale = 0.3f;
    public float maxScale = 0.5f;
 
    public void ApplyScaleRate() {
        transform.localScale += Vector3.one * scaleRate;
    }
  
    public void main() {
        if(transform.localScale.x < minScale) {
            scaleRate = Mathf.Abs(scaleRate);
        } else if (transform.localScale.x > maxScale) {
            scaleRate = -Mathf.Abs(scaleRate);
        }
        ApplyScaleRate();
    }

    void Start() {
    }
  
    void Update() {
        main();
    }

}
