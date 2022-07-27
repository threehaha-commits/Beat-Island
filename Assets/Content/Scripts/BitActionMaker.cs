using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class BitActionMaker : MonoBehaviour
{
    [SerializeField] private UnityEvent Action;
    [SerializeField] private AudioSource audioSource;
    [Range(0f, 1f)]
    [SerializeField] private float AudioDelay;

    private void Start()
    {
        StartCoroutine(BitTime());
    }

    private void Invoke(int Group)
    {
        Cancel();
        Action.SetPersistentListenerState(Group, UnityEventCallState.RuntimeOnly);
        Action.Invoke();
    }

    private void Cancel()
    {
        for(int i = 0; i < Action.GetPersistentEventCount(); i++)
        {
            Action.SetPersistentListenerState(i, UnityEventCallState.Off);
        }
    }

    private IEnumerator BitTime() 
    {
        yield return new WaitForSeconds(AudioDelay);
        audioSource.Play();
        int currentBit = 0;
        int MaxBit = 12;
        while (true)
        {
            yield return new WaitForSeconds(4f);
            currentBit = currentBit + 4;
            int bit = currentBit / 4;
            Invoke(bit - 1);
            if(currentBit >= MaxBit)
                currentBit = 0;
        }
    }
}
