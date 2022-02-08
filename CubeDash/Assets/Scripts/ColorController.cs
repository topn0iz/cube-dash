using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorController : MonoBehaviour
{
    public ColorChanger myColorChanger;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            Debug.Log("RED");
            //myColorChanger.myColor = Color.red;

            myColorChanger.ChangeColor(Color.red);
        }

        else if(Input.GetKeyDown(KeyCode.Keypad2))
        {
            Debug.Log("BLUE");

            myColorChanger.ChangeColor(Color.blue);
        }

        else if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            Debug.Log("YELLOW");

            myColorChanger.ChangeColor(Color.yellow);
        }

        else if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            Debug.Log("GREEN");

            myColorChanger.ChangeColor(Color.green);
        }

        else if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            Debug.Log("CYAN");

            myColorChanger.ChangeColor(Color.cyan);
        }

        else if (Input.GetKeyDown(KeyCode.Keypad6))
        {
            Debug.Log("BLACK");

            myColorChanger.ChangeColor(Color.black);
        }

        else if (Input.GetKeyDown(KeyCode.Keypad7))
        {
            Debug.Log("GAY");

            myColorChanger.ChangeColor(Color.magenta);
        }

        else if (Input.GetKeyDown(KeyCode.Keypad8))
        {
            Debug.Log("GREY");

            myColorChanger.ChangeColor(Color.grey);
        }

        else if (Input.GetKeyDown(KeyCode.Keypad9))
        {
            Debug.Log("PURPLE");

            myColorChanger.ChangeColor(new Color(.5f, 0f, .5f));
        }


    }
    
}
