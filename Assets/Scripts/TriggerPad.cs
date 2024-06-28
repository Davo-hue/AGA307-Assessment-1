using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPad : MonoBehaviour
{
    public GameObject sphere;   //The object we wish to change

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            sphere.gameObject.GetComponentInChildren<Renderer>().material.color = Color.green;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            sphere.transform.localScale = Vector3.one * 5f;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            sphere.transform.localScale = Vector3.one;
            sphere.gameObject.GetComponentInChildren<Renderer>().material.color = Color.yellow;
        }
    }
}

