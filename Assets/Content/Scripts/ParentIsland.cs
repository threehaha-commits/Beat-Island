using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ParentIsland : MonoBehaviour
{
    [SerializeField] protected IslandCell[] cells;

    private void Start()
    {
        for(int i = 0; i < cells.Length -1; i++)
        {
            if (cells[i].gameObject.CompareTag("Sacred"))
                continue;
            cells[i].SetNextCell(cells[i + 1]);
        }
    }
}
