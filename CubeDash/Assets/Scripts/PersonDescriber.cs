using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonDescriber : MonoBehaviour
{
    public string FirstName = "Heinrich";
    public char MiddleInitial = 'K';
    public string LastName = "Immelmann";
    public int Age = 32;
    public float Height = 74;
    public bool Bald = false;
    public PronounsStructure MyPronouns = new PronounsStructure("They", "Them", "Their", "Theirs");

    public string GetDescription()
    {
        string message = "\nThis person is named " + FirstName + " " + MiddleInitial + "." + " " + LastName + ".\n";
        message += MyPronouns.subjectivePronoun + " came to be " + Age + " years ago. " + MyPronouns.subjectivePronoun + 
            " can be measured at a height of " + Height + " inches.";
        
        if (Bald)
        {
            message += "\nYou are blown away by the sheer glow of a bald scalp.";
        }
        else
        {
            message += "\nWhat a boring head of hair.";
        }
        return message;
    }


    void Start()
    {
        Debug.Log(GetDescription());
    }
}
