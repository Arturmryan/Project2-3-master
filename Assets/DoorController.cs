using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{

    public GameObject instructions;
    public AudioSource audioPlayer;

    private void Start()
    {
        transform.eulerAngles = new Vector3(0, 180, 0);
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Door")
        {
            instructions.SetActive(true);
            Animator anim = other.GetComponentInChildren<Animator>();
            if (Input.GetKeyDown(KeyCode.E))
            {
                anim.SetTrigger("OpenClose");
                audioPlayer.Play();
            }
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Door")
        {
            instructions.SetActive(false);
        }
    }

}
