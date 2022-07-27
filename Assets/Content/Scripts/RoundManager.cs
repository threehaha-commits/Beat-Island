using UnityEngine;
using UnityEngine.Events;

public class RoundManager : MonoBehaviour
{
    [SerializeField] private UnityEvent _Start;

    private void Start()
    {
        Invoke();
    }

    public void AddListener(UnityAction action)
    {
        _Start.AddListener(action);
    }

    public void Invoke()
    {
        _Start.Invoke();
    }

}
