

using UnityEngine;

public class UnlockAbility : MonoBehaviour
{
    public bool slowDownTime;
    // use this for initialization
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            if (slowDownTime)
            {
                GameObject.FindWithTag("Player").GetComponent<SlowDownTime>().enabled = true;
                Destroy(gameObject);
            }

        }
    }
}





