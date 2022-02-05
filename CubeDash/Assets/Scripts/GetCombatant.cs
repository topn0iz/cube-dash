using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCombatant : MonoBehaviour
{
    public GoofStats Guy;
    public GoofStats Buddy;
    private void Start()
    {
        Debug.Log(Guy.Creedo);
    }
}
