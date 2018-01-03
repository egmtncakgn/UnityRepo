using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DurdurMenu : MonoBehaviour {

    public Button devam, anaM, durdurB;
    public bool aa;
    public GameObject panel, fpsS;

	// Use this for initialization
	void Start () {

        panel.SetActive(false);
        fpsS.SetActive(false);
	}
    public void A()
    {
        aa = !aa;
    }
    public void AA()
    {
        fpsS.SetActive(true);
    }
    public void AB()
    {
        fpsS.SetActive(false);
    }
    public void Devam()
    {
        panel.SetActive(false);
    }
    public void AnaM()
    {
        SceneManager.LoadScene(0);
    }
    public void DurdurM()
    {
        panel.SetActive(true);
    }
    private void Update()
    {
        if (aa)
        {
            AA();
        }
        else
        {
            AB();
        }
    }
}
