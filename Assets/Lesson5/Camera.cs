using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Vector3 scaleMultiplier = new Vector3(0.36f, 0.36f, 0.36f);
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = Vector3.Scale(transform.localScale, scaleMultiplier);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
