using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PewPewScript : MonoBehaviour
{
    public PlayerData STATS;
    public GameObject pewPewl;
    public GameObject pewPoint;
    public SpriteRenderer[] bars;
    public float heat;
    public float heatDecay;

    // Update is called once per frame
    void Update()
    {
        heat = Mathf.Max(heat - heatDecay * Time.deltaTime, 0);
        //if(heat >= 100)
        //{

        //}
    }

    public void Shoot()
    {
        Rigidbody2D bullet = Instantiate(pewPewl, pewPoint.transform.position, transform.rotation).GetComponent<Rigidbody2D>();
        bullet.AddForce(transform.up * STATS.bulletSped);
        Destroy(bullet.gameObject, STATS.bullitLife);
        heat += 1;
    }
}
