using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRot : MonoBehaviour
{
    public float speed = 20f;
    public float rotSpeed = 15f;

    // Update is called once per frame
    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();
        //rotate around Y
        transform.Rotate(0, 10 * rotSpeed, 0);
        transform.Translate(Random.Range(-5f, 5f) * 0.1f , 0, Random.Range(-5f, 5f) * 0.1f);
    }
}
