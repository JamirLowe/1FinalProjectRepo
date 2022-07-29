using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{ // The transform component is responsible for position rotation.
    public Transform player;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = player.position.z.ToString("0");
    }
}
