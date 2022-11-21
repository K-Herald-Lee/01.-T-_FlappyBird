using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makePipe : MonoBehaviour
{
    public GameObject pipe;
    float timer = 0;
    public float timeDiff;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timeDiff)
        {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = new Vector3(0, Random.Range(-2.0f, 1.4f), 1);
            timer = 0;
            Destroy(newPipe, 2.0f);
        }        
    }
}
