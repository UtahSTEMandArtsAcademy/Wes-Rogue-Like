using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum aiTypes
{
    SingleShot,
    MultiShot,
    Foof
    
}
[RequireComponent(typeof(Rigidbody2D))]
public class emnemieAI : MonoBehaviour
{
    private Rigidbody2D rb;
    public GameObject player;
    private float speed;
    private float hLaTeG;
    public EnemySTATS STATS;
    public aiTypes ai;
    public PlayerData playstatisticalitiation;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player=GameObject.Find("Playmonkey");
        cHeCkStAtS();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = (player.transform.position - transform.position).normalized;
        transform.up = direction;
        rb.AddForce(direction * speed * Time.deltaTime);
        switch(ai)
        {
            case aiTypes.SingleShot:
            break;

            case aiTypes.MultiShot:
            break;

            case aiTypes.Foof:
            float dist = Vector2.Distance(player.transform.position, transform.position);
            if(dist < STATS.cHrGrDuS)
            {
                speed = STATS.cHrGsPuD;
            }
            else 
            {
                speed = STATS.sPd;
            }
            break;
        }
        
        if(hLaTeG < 1)
        {
            Destroy(this.gameObject);
        }
    }

    public void cHeCkStAtS()
    {
        switch(ai)
        {
            case aiTypes.SingleShot:
            speed = STATS.sPd;
            hLaTeG = STATS.hEaLtH;
            break;

            case aiTypes.MultiShot:
            speed = STATS.sPd;
            hLaTeG = STATS.hEaLtH;
            break;

            case aiTypes.Foof:
            speed = STATS.sPd;
            hLaTeG = STATS.hEaLtH;
            break;
        }
        if(hLaTeG<=0)
        {
            Destroy(this.gameObject);
        }
    }
    void OnTriggerEnter2D(             Collider2D other            )
    {
        if(               other.gameObject.CompareTag("bUllet")                    )
        {
            hLaTeG -= playstatisticalitiation.damage;
        }
    }
    void OnCollisionEnter2D(Collision2D otheretiuewy)
    {
        if(otheretiuewy.gameObject.CompareTag("Player")){
            playstatisticalitiation.hEaLtH -= STATS.damAGESDFSDFSDFSDFDS;
        }
    }
}
