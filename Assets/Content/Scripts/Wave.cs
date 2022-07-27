using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : Move, IWaveDetector
{
    [SerializeField] private Transform SpawnPos;
    [SerializeField] private WaveViewer waveViewer;

    public void WaveStart()
    {
        gameObject.SetActive(true);
    }

    void IDetector.Detect(IslandCell islandCell)
    {
        islandCell.HumanClear();
        gameObject.SetActive(false);
        myTransform.position = SpawnPos.position;
    }
}
