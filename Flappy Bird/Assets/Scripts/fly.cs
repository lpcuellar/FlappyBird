using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fly : MonoBehaviour
{
    public GameManager gameManager;
    public float velocity = 1.4f;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            rb.velocity = Vector2.up * velocity;
            Debug.Log("Vuela");
            sfx.PlaySound("sfx_wing");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GameOver();
        sfx.PlaySound("sfx_hit");
        sfx.PlaySound("sfx_die");


    }
}
