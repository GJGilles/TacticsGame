using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/UnitObject", order = 0)]
public class UnitObject : ScriptableObject
{
    public int hpBase;
    public int hpCurrent;

    public int str;
    public int def;
    public int spd;

    public List<CombatArtObject> arts = new List<CombatArtObject>();
}
