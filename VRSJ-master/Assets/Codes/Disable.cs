using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disable : MonoBehaviour
{
    public AudioSource locksound;
    public GameObject toDisable;
    public Rigidbody rdb;

    public void ButtonAction()
    {
        locksound.Play();

        if (toDisable)
        {
            toDisable.SetActive(false);
        }

        if (rdb)
        {
            rdb.AddForce(Vector3.up * 5, ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (locksound)
        {
            locksound.Play();
        }
    }

}