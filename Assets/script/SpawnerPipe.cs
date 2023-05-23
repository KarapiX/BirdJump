using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerPipe : MonoBehaviour
{
    public float maxTime = 1;
    private float time = 0;
    public GameObject pipe;
    public float height;


    // Update is called once per frame
    void Update()
    {
        if (time > maxTime)
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            time = 0;
        }
        time += Time.deltaTime;
    }
}
