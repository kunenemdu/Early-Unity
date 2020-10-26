using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    GameObject coin;
    static int count = 0;
    void Awake()
    {
        coin = this.gameObject;
    }
    void OnTriggerEnter(Collider other)
    {
        coin.SetActive(false);
        count++;
        Debug.Log(count);
    }
}