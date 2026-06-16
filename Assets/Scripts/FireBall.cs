using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    [SerializeField] int force;
    [SerializeField] private GameObject ball;
    [SerializeField] private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        ball = transform.Find("Ball").gameObject;
        rb = ball.GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update()
    {
        Movement();

    }

    //Launch the ball on left mouse input
    void Movement()
    {
        if (Input.GetKey(KeyCode.Mouse0) && ball.transform.parent != null)
        {
            rb.AddForce(transform.up * force, ForceMode.Acceleration);
            ball.transform.parent = null;

            //Add a random force so ball fires in a controlled but random direction
            float LRForce = Random.Range(-20.0f, 20.0f);
            rb.AddForce(Vector3.left *  LRForce, ForceMode.Impulse);
        }
    }
}
