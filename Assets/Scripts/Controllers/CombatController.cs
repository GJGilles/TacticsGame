using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatController : MonoBehaviour
{
    private class TurnData
    {
        public int delay = 0;

        public CombatArtObject action = null;
        public CombatUnitController unit = null;
    }

    private List<TurnData> turns = new List<TurnData>();
    private List<CombatUnitController> board = new List<CombatUnitController>();

    public void Init(List<UnitObject> units)
    {
        foreach (var u in units)
        {

        }
    }
}
