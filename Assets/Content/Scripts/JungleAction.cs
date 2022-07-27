using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JungleAction : IslandActionParent
{
    [SerializeField] private BitAction jungle;

    protected override void StartAction()
    {
        List<int> count = HumanCount();
        count.Sort();
        jungle.Play(cell[count[0]].transform);
    }

    private List<int> HumanCount()
    {
        List<int> humanCount = new List<int>();
        for(int i = 0; i < cell.Length; i++)
        {
            humanCount.Add(cell[i].GetCount());
        }
        return humanCount;
    }
}
