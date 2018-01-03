using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButonKod : MonoBehaviour
{
    public GameObject oyuncu;
    public Oyuncu karakterKont;

    // Use this for initialization
    void Start()
    {
        karakterKont = oyuncu.GetComponent<Oyuncu>();
    }


    public void SagButonBas()
    {
        karakterKont.sagaGit = true;
        karakterKont.solaGit = false;
    }

    public void SolButonBas()
    {
        karakterKont.solaGit = true;
        karakterKont.sagaGit = false;
    }

    public void ButonaBasma()
    {
        karakterKont.solaGit = false;
        karakterKont.sagaGit = false;
    }
}