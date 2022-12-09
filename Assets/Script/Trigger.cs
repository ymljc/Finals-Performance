using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject success;

    // Start is called before the first frame update

    private void OnTriggerEnter(Collider player){
        if (player.gameObject.tag == "Player")
        {
            success.SetActive(true);
            DeltaTimePaused();
        }
    }
    // Update is called once per frame
    public void DeltaTimePaused()
    {
        Time.timeScale = 0f;
    }
    public void DeltaTimeResume()
    {
        Time.timeScale = 1f;
    }
}