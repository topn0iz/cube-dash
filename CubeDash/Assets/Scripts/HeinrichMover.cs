using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeinrichMover : MonoBehaviour
{
    public float jumpVelocityY = 6;
    public Rigidbody2D myRigidbody;
    public float speed = 3;
    public void Start()
    {
        
    }

    public void Update()
    {
        float h = GetHorizontalInput();
        transform.position = transform.position + new Vector3(h * speed * Time.deltaTime, 0, 0);

        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("Hueh!");
            myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpVelocityY);
        }

    }
    private float GetHorizontalInput()
    {
        float h = Input.GetAxis("Horizontal");
        return h;
    }

    

}
