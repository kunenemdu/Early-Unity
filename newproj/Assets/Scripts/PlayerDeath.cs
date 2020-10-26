using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    public GameObject blood;

    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        //Instantiate(blood, transform.position, Quaternion.identity);
    }
}
