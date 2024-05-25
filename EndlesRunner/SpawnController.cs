using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    private PlayerController player;
    private float disapearZ = -20f;
    public bool destroyOnEnd = false;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * player.speed * Time.deltaTime, Space.World);
        if(transform.position.z < disapearZ){
            if(destroyOnEnd){
                Destroy(gameObject);
            }
            transform.position = transform.position + Vector3.forward * SpawnManager.drawDistance;
        }
    }
}
