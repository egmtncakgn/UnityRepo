using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P : MonoBehaviour {

    public GameObject up;
    

    private void Start()
    {
        up = GameObject.FindGameObjectWithTag("Game");
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            up.GetComponent<UpOne>().puan += 1;
            Destroy(gameObject);
        }

        if (col.gameObject.tag == "Yer")
        {
            up.GetComponent<UpOne>().dusenP += 1;
            Destroy(gameObject);
        }
    }
    void Update () {

	}
}
