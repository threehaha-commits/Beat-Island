using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] protected float Speed;
    [SerializeField] protected Transform Target;
    protected Transform myTransform { get; private set; }
    private const float TimeForMove = 4f;

    public void Construct(Transform Target)
    {
        this.Target = Target;
        myTransform = transform;
    }

    protected virtual void Update()
    {
        if (Target == null)
            return;
        float Distance = (Target.position - myTransform.position).magnitude;
        Speed = Distance / 4;
        myTransform.position = Vector3.MoveTowards(myTransform.position, Target.position, Speed * Time.deltaTime);
    }
}
