using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arabaDonus : MonoBehaviour
{
    public Vector3 rotasyon;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localEulerAngles += rotasyon * Time.deltaTime;
            
    }
}
