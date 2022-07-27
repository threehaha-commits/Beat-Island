using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveViewer : MonoBehaviour
{
    [SerializeField] private List<Wave> Wave = new List<Wave>();

    public void WaveAdd(Wave wave)
    {
        Wave.Add(wave);
    }

    public void WaveRemove(Wave wave)
    {
        Wave.Remove(wave);
    }

    public int WaveCount() 
    {
        return Wave.Count;
    }
}
