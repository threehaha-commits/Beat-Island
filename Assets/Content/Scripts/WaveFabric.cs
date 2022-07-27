using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveFabric : MonoBehaviour
{
    [SerializeField] private List<Wave> WaveList = new List<Wave>();
    [SerializeField] private List<Transform> TheTargetForMove = new List<Transform>();
    [SerializeField] private RoundManager roundManager;
    private readonly float BitTime = 4f;
    private const int WaveCount = 2;
    [Range(0f, 1f)]
    [SerializeField] private float AudioDelay;

    private void Awake()
    {
        roundManager.AddListener(StartSpawn);
    }

    private void StartSpawn() 
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        yield return new WaitForSeconds(AudioDelay);
        while (true)
        {
            List<Wave> Waves = new List<Wave>(WaveList);
            Waves.ForEach(wave =>
            {
                wave.gameObject.SetActive(false);
            });
            for (int i = 0; i < WaveCount; i++)
            {
                int random = Random.Range(0, Waves.Count);
                Waves[random].Construct(TheTargetForMove[random]);
                Waves[random].WaveStart();
                Waves.Remove(Waves[random]);
            }
            yield return new WaitForSeconds(BitTime);
        }
    }
}
