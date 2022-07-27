using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    private TMP_Text txt;
    private int Second;
    private int Minute;
    [SerializeField] private GameCondition condition;

    private void Start()
    {
        txt = GetComponent<TMP_Text>();
        Second = 60;
        Minute = 3;
        StartCoroutine(StartTimer());
    }

    private IEnumerator StartTimer() 
    {
        while (Minute >= 0) 
        {
            Second--;
            if(Second == 0)
            {
                Minute--;
                Second = 60;
            }
            if(Second > 9)
                txt.text = $"{Minute}:{Second}";
            else
                txt.text = $"{Minute}:0{Second}";
            yield return new WaitForSeconds(1);
        }
        txt.gameObject.SetActive(false);
        condition.End();
    }
}
