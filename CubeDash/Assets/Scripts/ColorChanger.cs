using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    private bool canChangeColor = true;
    public Color myColor;
    public SpriteRenderer mySpriteRenderer;

    public void ChangeColor(Color newColor)
    {
        if (canChangeColor == true)
        {
            mySpriteRenderer.color = newColor;
        }
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //ChangeColor(Random.ColorHSV());
            ChangeColor(Random.ColorHSV());
            canChangeColor = !canChangeColor;
            if (canChangeColor == true)
            {
            Debug.Log("Nice");
            }
            else
            {
                Debug.Log("Dang");
            }

        }

    }
   



}

