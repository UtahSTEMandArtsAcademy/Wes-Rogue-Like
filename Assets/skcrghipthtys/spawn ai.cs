using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnai : MonoBehaviour

{
    public GameObject[] spawasdygdsfigseiurf;
    private float timErSFfgRTsdf;
    public float interfASGfgsdfSfdg;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timErSFfgRTsdf+=Time.deltaTime;
        if(timErSFfgRTsdf>interfASGfgsdfSfdg)
        {
            Instantiate(spawasdygdsfigseiurf[Random.Range(0,spawasdygdsfigseiurf.Length)],new Vector2(Random.Range(-100, 100), Random.Range(-100, 100)),transform.rotation);
            timErSFfgRTsdf=0;
        }
    }
}
