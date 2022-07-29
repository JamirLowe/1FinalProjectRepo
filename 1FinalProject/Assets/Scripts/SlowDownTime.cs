
using UnityEngine;

public class SlowDownTime : MonoBehaviour {

    // Use this for initialization
    void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            Time.timeScale = 0.1f;//0.65f
        }
        else
            Time.timeScale = 1;//1
    }
}
