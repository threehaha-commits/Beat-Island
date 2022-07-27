using UnityEngine;

interface IIslandDetector
{
    void Detect(IDetector humanDetector);
}

interface IDetector
{
    void Detect(IslandCell islandCell);
}

interface IHumanDetector : IDetector { }
interface IWaveDetector : IDetector { }

public class CollisionDetector : MonoBehaviour
{
    private IIslandDetector mainDetector;

    private void Start()
    {
        mainDetector = GetComponent<IIslandDetector>();
    }

    private void OnTriggerEnter(Collider collision)
    {
        mainDetector.Detect(collision.GetComponent<IDetector>());
    }
}
