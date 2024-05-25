using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] gameObjects;
    public Transform leftPoint, rightPoint;
    public float objectSize = 20f;
    public static float drawDistance = 500f;

    private float lastSpawnZ;
    // Start is called before the first frame update
    void Start()
    {
        LoadObjects();
        lastSpawnZ = transform.position.z;
        while(transform.position.z - lastSpawnZ <= objectSize && lastSpawnZ < drawDistance){
            int index = Random.Range(0, gameObjects.Length-1);
            Vector3 rightPos = rightPoint.position + new Vector3(0,0,lastSpawnZ + objectSize) ;
            Vector3 leftPos = leftPoint.position + new Vector3(0,0,lastSpawnZ + objectSize) ;
            Instantiate(gameObjects[index], leftPos, leftPoint.rotation);
            index = Random.Range(0, gameObjects.Length-1);
            Instantiate(gameObjects[index], rightPos, rightPoint.rotation);
            lastSpawnZ += objectSize;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void LoadObjects(){
        gameObjects = Resources.LoadAll<GameObject>("Buildings");
    }
}
