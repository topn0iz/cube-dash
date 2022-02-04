using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeinrichMover : MonoBehaviour
{
    public float speed = 3;
    public void Start()
    {
        
    }

    public void Update()
    {
        float h = GetHorizontalInput();
        transform.position = transform.position + new Vector3(h * speed * Time.deltaTime, 0, 0);
    }
    private float GetHorizontalInput()
    {
        float h = Input.GetAxis("Horizontal");
        return h;
    }
}
