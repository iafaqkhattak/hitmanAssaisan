using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public int speed = 3;
    public int js = 3;

    private Rigidbody2D rigidbody1;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody1 = GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    void Update()
    {

        float move = Input.GetAxis("Horizontal");
        Debug.Log("move");
        rigidbody1.velocity = new Vector2(move * speed, rigidbody1.velocity.y);




    }
}
