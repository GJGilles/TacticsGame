using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/CombatArtObject", order = 0)]
public class CombatArtObject : ScriptableObject
{
    public string title = "";
    public int damage = 0;
    public List<Vector2> area = new List<Vector2>();

    public int useTime = 0;
    public int coolTime = 0;
}