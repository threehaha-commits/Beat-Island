using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanFabric : MonoBehaviour
{
    [SerializeField] private Human human;
    [SerializeField] private List<GameObject> Wave = new List<GameObject>();
    [SerializeField] private RoundManager roundManager;
    [SerializeField] private Transform[] SpawnPoint;
    [SerializeField] private Transform Volcano;
    [SerializeField] private Transform[] Sand;

    private const int SpawnTime = 2;
    private const int CountHuman = 5;
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
            int random = Random.Range(0, SpawnPoint.Length);
            int randomCount = Random.Range(1, CountHuman);

            List<GameObject> list = new List<GameObject>(Wave);
            for(int i = 0; i < list.Count; i++)
            {
                if(list[i].activeInHierarchy)
                {
                    list.RemoveAt(i);
                }
            }

            for (int i = 0; i < randomCount; i++)
            {
                float x = Random.Range(list[i].transform.position.x - 2f, list[i].transform.position.x + 2f);
                float z = Random.Range(list[i].transform.position.z - 2f, list[i].transform.position.z + 2f);
                Vector3 position = new Vector3(x, list[i].transform.position.y, z);
                Human _human =  Instantiate(human, position, Quaternion.identity);
                _human.Construct(Sand[i]);
            }
            yield return new WaitForSeconds(SpawnTime);
        }
    }
}
