using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 10;
    

    // Start is called before the first frame update
    void Start()
    {
        spawPipe ();
    }

    // Update is called once per frame
    void Update()
    {
        if ( timer < spawnRate){
            timer = timer + Time.deltaTime;
        }
        else{
            spawPipe();
            timer = 0;
        }
    }
    void spawPipe (){
        float lowestPoint = transform.position.y - heightOffset;
        float highestPOint = transform.position.y + heightOffset;
         Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPOint), 0), transform.rotation);
    }

}
