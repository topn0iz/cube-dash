using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonDescriber : MonoBehaviour
{
    public Person Guy;
    public Person Buddy;

    void Start()
    {
        Debug.Log(Guy.GetDescription());
    }


}
