
using UnityEngine;
using System;
[Serializable]
public struct GoofStats
{
    public string NameOfCombatant;
    public string CountryOfOrigin;
    public Date DateOfConception;
    public char CombatGrade;
    public int Heart;
    public int Gumption;
    public int Gall;
    public int Bravado;
    public string Creedo;
    public bool Based;

    public int GetAge()
    {
        DateTime DOB = new DateTime(DateOfConception.Year, DateOfConception.Month, DateOfConception.Day);
        DateTime Today = DateTime.Now;

        return (int)((Today - DOB).TotalDays / 365);

       
    }


}
[Serializable]
public struct Date
{
    public int Month;
    public int Day;
    public int Year;
}
