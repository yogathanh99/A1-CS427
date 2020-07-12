using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour
{
    public float speed=5f;
    public float jump=100f;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
       animator= GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)) //Control by keyboard with left arrow button
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-speed, 0)); //Apply force on x axis
            GetComponent<SpriteRenderer>().flipX = true; // change facing direction
            GetComponent<Animator>().SetTrigger("Run");
        }
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(speed, 0));
            GetComponent<SpriteRenderer>().flipX = false;
            GetComponent<Animator>().SetTrigger("Run");
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jump));
        }
    }
}
