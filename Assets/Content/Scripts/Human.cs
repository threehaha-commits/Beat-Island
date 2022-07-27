using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : Move, IHumanDetector
{
    protected override void Update()
    {
        base.Update();
        myTransform.rotation = Quaternion.FromToRotation(myTransform.forward, Target.position - myTransform.position);
    }

    void IDetector.Detect(IslandCell islandCell)
    {
        islandCell.AddHuman();
        gameObject.SetActive(false);
    }
}
