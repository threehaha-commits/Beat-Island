using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class RestartUI : MonoBehaviour
{
    [SerializeField] private TMP_Text text;

    private void OnEnable()
    {
        text.text = "Curent Score: "  + HumanCountText.GetCount() + " / " + "Best score: " + PlayerPrefs.GetInt("Count");
    }

    public void Restart() 
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
