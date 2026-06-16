using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    [SerializeField] private float paddleWidth;
    //[SerializeField] Vector3 mousePos;
    // Start is called before the first frame update
    void Start()
    {
        paddleWidth = GetComponent<Renderer>().bounds.size.z / 2;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = MouseWorldPos();
    }

    //Get position of mouse and move paddle according to mouse movement
    Vector3 MouseWorldPos()
    {
        Vector3 mousePos;
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.y = transform.position.y;
        mousePos.z = transform.position.z;

       mousePos.x = Mathf.Clamp(mousePos.x, (-ScreenDimensions.screenWidth / 2) + paddleWidth, (ScreenDimensions.screenWidth / 2) - paddleWidth);


        return mousePos;
    }
}
