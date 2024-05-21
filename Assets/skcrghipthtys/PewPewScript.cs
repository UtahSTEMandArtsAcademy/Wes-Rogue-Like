using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class PewPewScript : MonoBehaviour
{
    public PlayerData STATS;
    public GameObject pewPewl;
    public GameObject pewPoint;
    public float heat;
    public float heatDecay;
    public PlayerData heet;
    public bool shotyesorno;
    public Color lerpedColor;
    public Color[] colors;
    public SpriteRenderer ring;
    // Update is called once per frame
    void Update()
    {
        heat = Mathf.Max(heat - heatDecay * Time.deltaTime, 0);
        heatDecay = Mathf.Min(heatDecay * 1.03f, 300);
        if(heat >= heet.relaod)
        {
            shotyesorno = false;

        }
        else
        {
            shotyesorno = true;
        }
        lerpedColor = Color.Lerp(colors[0], colors[1], heat/STATS.relaod);
        ring.material.color = lerpedColor;
    }

    public void Shoot()
    {
        if (shotyesorno==true)
        {
            Rigidbody2D bullet = Instantiate(pewPewl, pewPoint.transform.position, transform.rotation).GetComponent<Rigidbody2D>();
            bullet.AddForce(transform.up * STATS.bulletSped);
            Destroy(bullet.gameObject, STATS.bullitLife);
            heat += 1;
            heatDecay = 2;

        }

    }
}
