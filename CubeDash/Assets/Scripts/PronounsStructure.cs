

[System.Serializable]
public struct PronounsStructure
{
   public string subjectivePronoun;
   public string objectivePronoun;
   public string possessivePronoun;
   public string pluralPossessivePronoun;

    public PronounsStructure(string sub, string obj, string pos, string plpos)
    {
        subjectivePronoun = sub;
        objectivePronoun = obj;
        possessivePronoun = pos;
        pluralPossessivePronoun = plpos;
    }

}

//what happens when pronoun not capitalized???
// find out next time
