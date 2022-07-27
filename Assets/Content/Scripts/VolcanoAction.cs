using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolcanoAction : IslandActionParent
{
    [SerializeField] private BitAction[] Volcano;

    protected override void StartAction()
    {
        int random = Random.Range(0, cell.Length);
        List<IslandCell> cells = new List<IslandCell>(cell);
        cells.RemoveAt(random);
        for(int i = 0; i < cells.Count; i++)
        {
            Volcano[i].Play(cells[i].transform);
        }
    }
}
