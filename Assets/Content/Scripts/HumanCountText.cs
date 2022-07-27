using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HumanCountText : MonoBehaviour
{
    private TMP_Text m_Text;
    private static int Count;

    private void Start()
    {
        Count = 0;
        m_Text = GetComponent<TMP_Text>();
    }

    public static int GetCount()
    {
        int c = Count;
        return c;
    }

    public void ChangeText(int count)
    {
        Count = Count + count;
        m_Text.text = "Human Count: " + Count.ToString();
        Saver.Save(Count);
    }
}

public class Saver
{
    public static void Save(int Count) 
    {
        int count = PlayerPrefs.GetInt("Count");
        if(Count > count)
            PlayerPrefs.SetInt("Count", Count);
    }
}
