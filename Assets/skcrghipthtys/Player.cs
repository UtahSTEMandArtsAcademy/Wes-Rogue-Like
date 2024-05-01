using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerData STATS;
    public Rigidbody2D rigidbodyTwoDimensenional;
    public PewPewScript gun;
    // doodly doo doo
    void Start()
    {
        rigidbodyTwoDimensenional = GetComponent<Rigidbody2D>();
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
    }
}
