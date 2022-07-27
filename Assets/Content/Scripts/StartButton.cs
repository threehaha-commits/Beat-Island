using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    private void Start()
    {
        Time.timeScale = 0f;
    }

    public void StartGame() 
    {
        gameObject.SetActive(false);
        Time.timeScale = 1f;
    }
}
