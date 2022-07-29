using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour {
   

public void Quit ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}