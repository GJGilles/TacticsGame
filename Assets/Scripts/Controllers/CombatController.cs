using System.Collections;
using System.Collections.Generic;
using System.Linq;
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

    private void ProcessTurn()
    {
        var t = turns[0];
        turns.RemoveAt(0);

        if (t.action != null)
        {
            ProcessAction(t);
        }
        if (t.unit.data.npc)
        {
            // Determine npc ai
        } 
        else
        {
            // Ask for player input 
        }
    }

    private void ProcessAction(TurnData t)
    {
        foreach (var unit in board)
        {
            bool hit = false;
            foreach (var point in t.action.area)
            {
                if (unit.position.Contains(t.unit.position.min + point))
                {
                    hit = true;
                    continue;
                }
            }

            if (hit)
            {
                unit.TakeDamage(t.action.damage * t.unit.data.str);
                continue;
            }
        }
    }
}
