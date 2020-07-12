using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateFirePoint : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)) //Control by keyboard with left arrow button
        {
            transform.Rotate(0f,180f,0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0f,180f,0f);
        }
        
    }
}
