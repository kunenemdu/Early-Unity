using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;
    public GameObject blood;
    MeshRenderer mr;
    CharacterController character;
    void Start()
    {
        mr = player.GetComponent<MeshRenderer>();
        character = player.GetComponent<CharacterController>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            mr.enabled = false;
            character.enabled = false;
            Instantiate(blood, transform.position, Quaternion.identity);
            Invoke("Respawn", 2f);
        }
    }

    void Respawn()
    {
        player.transform.position = respawnPoint.transform.position;
        mr.enabled = true;
        character.enabled = true;
        Physics.SyncTransforms();
    }

    void Update()
    {
        Destroy(GameObject.Find("PlayerDeath(Clone)"), 1f);
    }
}
