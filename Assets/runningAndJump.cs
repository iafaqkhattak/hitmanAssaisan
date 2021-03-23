using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunningAndJumpScript : MonoBehaviour
{

    public float speed =3;
    public float js =3;


        private Rigidbody2D rigidbody;
    public Animator animate;
        
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        Debug.Log("move");
        rigidbody.velocity = new Vector2(move * speed, rigidbody.velocity.y);
        if (Input.GetKeyDown(KeyCode.Space))
        {

            rigidbody.velocity = new Vector2(rigidbody.velocity.y, speed);

        }
    }
}
