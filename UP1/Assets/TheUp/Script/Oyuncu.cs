using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oyuncu : MonoBehaviour
{

    public bool sagaGit, solaGit;
    Rigidbody2D rb;
    public float hiz = 7f;
    public UpOne up;

    // Use this for initialization
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (sagaGit)
        {
            rb.velocity = new Vector2(hiz, rb.velocity.y);
        }
        else if (solaGit)
        {
            rb.velocity = new Vector2(-hiz, rb.velocity.y);
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }
}
