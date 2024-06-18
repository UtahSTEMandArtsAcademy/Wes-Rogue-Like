using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerData STATS;
    public Rigidbody2D rigidbodyTwoDimensenional;
    public PewPewScript gun;
    public GameObject forTheUi;
    // doodly doo doo
    void Start()
    {
        rigidbodyTwoDimensenional = GetComponent<Rigidbody2D>();
        STATS.hEaLtH = 10;
    }

    // this happens
    void Update()
    {
        float acheTeeAcheZee = Input.GetAxisRaw("Horizontal");
        float veeTeeVeeZee = Input.GetAxisRaw("Vertical");
        rigidbodyTwoDimensenional.velocity = new Vector2(acheTeeAcheZee, veeTeeVeeZee).normalized * STATS.speed * Time.deltaTime;
        Vector2 mouseScreenPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = (mouseScreenPosition - (Vector2)transform.position).normalized;
        transform.up = direction;

        if (Input.GetButton("Fire1"))
        {
            gun.Shoot();
        }

        if(STATS.hEaLtH <= 0){
            Destroy(this.gameObject);
        }
    }

    void OnDestroy()
    {
        forTheUi.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "unbullet")
        {
            STATS.HealthChange(-1);
        }
    }

}
