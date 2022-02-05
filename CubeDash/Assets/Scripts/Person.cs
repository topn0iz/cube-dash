

using System;
using UnityEngine;
[Serializable]


public class Person
{
    public string FirstName;
    public char MiddleInitial;
    public string LastName;
    public int Age;
    public float Height;
    public bool Bald;
    public PronounsStructure MyPronouns;

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
}
