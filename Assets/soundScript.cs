using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundScript : MonoBehaviour
{
    public AudioSource squeakSource;

    private void Start()
    {
        squeakSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Door")
        {
            squeakSource.Play();
        }
    }
}
