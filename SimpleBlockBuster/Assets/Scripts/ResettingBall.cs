using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResettingBall : MonoBehaviour
{
    [SerializeField] private GameObject paddle;
    [SerializeField] private GameObject spawnPoint;
    [SerializeField] private float minY;
    // Start is called before the first frame update
    void Start()
    {
        minY = -3;
    }

    // Update is called once per frame
    void Update()
    {
       CheckForBall();
    }

    float PositionY()
    {
        return gameObject.transform.position.y;
    }

    //if the ball falls outside the screen reset its position to the paddle
    void CheckForBall()
    {
        if(PositionY() < minY)
        {
            gameObject.transform.position = spawnPoint.transform.position;
            this.GetComponent<Rigidbody>().linearVelocity = Vector3.zero;
            transform.parent = paddle.transform;
        }
    }
}
