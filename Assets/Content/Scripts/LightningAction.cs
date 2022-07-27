using System.Collections;
using UnityEngine;

public class LightningAction : IslandActionParent
{
    [SerializeField] private BitAction[] Lightning;

    protected override void StartAction()
    {
        int random = Random.Range(0, cell.Length - 1);
        Lightning[0].Play(cell[random].transform);
        Lightning[1].Play(cell[random + 1].transform);
    }
}
