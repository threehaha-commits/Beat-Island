using UnityEngine;

public class GameCondition : MonoBehaviour
{
    [SerializeField] private GameObject ConditionObject;

    public void End()
    {
        Time.timeScale = 0f;
        ConditionObject.SetActive(true);
    }
}
