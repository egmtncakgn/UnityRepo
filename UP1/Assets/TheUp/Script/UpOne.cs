using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpOne : MonoBehaviour {

    public GameObject p, oyuncu, yer;
    public Text _puan, _can;
    public float spawnZaman;
    public int level, spawnSayi, spawnHiz, puan, can, dusenP, spawnS;

    void Start()
    {
        level = 1;
        spawnZaman = 5f;
        spawnSayi = 10;
        spawnHiz = 2;
        puan = 0;
        can = 3;
        spawnS = spawnSayi;

    }

    void SpawnEt()
    {
        if (spawnZaman <= 0)
        {
            if (spawnS > 0)
            {
                Vector3 position = new Vector3(Random.Range(-3f, 3f), 8, -10);
                Instantiate(p, position, Quaternion.identity);

                spawnS -= 1;
            }

            if(spawnS <= 0)
            {
                LevelUp();
                spawnS = spawnSayi;
            }
            spawnZaman = 5f;
        }
    }

    void LevelUp()
    {
        level++;
        spawnZaman -= 0.2f;
        spawnSayi += 3;
        puan += 10;
        can += 1;
    }


    void Update()
    {
        spawnZaman -= spawnHiz * Time.deltaTime;

        SpawnEt();

        Text _c = _can.GetComponent<Text>();
        _c.text = "Can:" + "" + can.ToString();

        Text _pu = _puan.GetComponent<Text>();
        _pu.text = puan.ToString();

        if (dusenP >= 10)
        {
            can -= 2;
            dusenP = 0;
        }
    }
}
