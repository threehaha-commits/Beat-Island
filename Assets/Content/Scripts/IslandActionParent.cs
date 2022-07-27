using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IslandActionParent : MonoBehaviour
{
    [SerializeField] protected IslandCell[] cell;

    protected abstract void StartAction();
}
