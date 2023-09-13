using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public float maxTime = 1 ;
    private float timer  = 0 ;
    public  GameObject skyscraper ;
    public float height;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            GameObject newSkycraper = Instantiate(skyscraper,transform.position + new Vector3 (0, Random.Range(-height,height),0),Quaternion.identity , transform);
            Destroy(newSkycraper,15);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
