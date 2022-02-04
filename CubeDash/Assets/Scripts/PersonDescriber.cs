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
    //public int PronounsIndex = 0;


    //public string[] Pronouns = new string[] { "They", "Them" };
    //public string[] 

    //public string[] GetPronouns()
    //{
    //    string SubjectivePronouns = "";
    //    string ObjectivePronouns = "";
    //    string PossessivePronouns = "";
    //    //if (PronounsIndex == 0)
    //    //{
    //    //    //return new string[] { "He", "Him", "His" };
    //    //    //

    //    //    SubjectivePronouns = "He";
    //    //    ObjectivePronouns = "Him";
    //    //    PossessivePronouns = "His";
    //    //}
    //    //else if (PronounsIndex == 1)
    //    //{
    //    //    SubjectivePronouns = "She";
    //    //    ObjectivePronouns = "Her";
    //    //    PossessivePronouns = "Hers";
    //    //}
    //    //else if (PronounsIndex == 2)
    //    //{
    //    //    SubjectivePronouns = "They";
    //    //    ObjectivePronouns = "Them";
    //    //    PossessivePronouns = "Their";
    //    //}

    //    return new string[] { SubjectivePronouns, ObjectivePronouns, PossessivePronouns };
    // ALL OF THIS IS REPLACED WITH PRONOUNSSTRUCTURE SCRIPT
    //}

    public string GetDescription()
    {
        //string m = string.Format("This person's name is {0} {1} {2}.\n", FirstName, MiddleInitial, LastName);
        //Previous method allows removal of '+ " " +' but I don't like it.
        //It requires planning assignment of variables instead of just writing the variable names.
        string message = "\nThis person is named " + FirstName + " " + MiddleInitial + " " + "." + LastName + ".\n";
        message += MyPronouns.objectivePronoun + " came to be " + Age + " years ago. " + MyPronouns.objectivePronoun.ToLower() + " can be measured at a height of " + Height + " inches.";
        
        if (Bald)
        {
            message += "\nYou are blown away by the sheer glow of a bald scalp.";
        }
        else
        {
            message += "\nWhat a boring head of hair.";
        }
        return message;

        //string message2 = "this will not work";
        //return message2; 
        //you can't put stuff after return, stupid
    }


    void Start()
    {
        //Debug.Log(FirstName);
        //string message = "Personally, I prefer the air.";
        //Debug.Log(message);
        //Debug.Log("another thing");
        //Debug.Log(87);
        //message = "Hands off my cawk!";
        //Debug.Log(message);
        
        Debug.Log(GetDescription());

       //string FirstName;
       //char MiddleInitial = 'K';
       //string LastName = "Immelmann";
       //int Age = 32;
       //int Height = 74;
       //bool Bald = false;
    }

   

    void Update()
    {
        
    }
}
