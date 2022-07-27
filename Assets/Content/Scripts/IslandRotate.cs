using UnityEngine;

public class IslandRotate : MonoBehaviour
{
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
            transform.localEulerAngles = new Vector3(0, transform.localEulerAngles.y + 60f, 0);
        if (Input.GetKeyDown(KeyCode.S))
            transform.localEulerAngles = new Vector3(0, transform.localEulerAngles.y - 60f, 0);
    }
}
